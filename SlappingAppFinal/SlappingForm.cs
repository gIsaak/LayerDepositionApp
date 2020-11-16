using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CU30Interface;
using Nikon;
using Thorlabs.MotionControl.DeviceManagerCLI;
using Thorlabs.MotionControl.GenericMotorCLI;
using Thorlabs.MotionControl.KCube.DCServoCLI;


namespace SlappingAppFinal
{
    public partial class SlappingForm : Form
    {
        // Camera
        private NikonManager manager;
        private NikonDevice device;
        private Timer liveViewTimer;
        // Stage
        private CU30 CU30obj = new CU30();
        // Fiber
        private KCubeDCServo _kCubeDCServoMotor = null;

        public SlappingForm()
        {
            InitializeComponent();
        }

        private void SlappingForm_Load(object sender, EventArgs e)
        {
            #region Camera initialization
            // Disable buttons
            ToggleCameraButtons(false);
            // Initialize live view timer
            liveViewTimer = new Timer();
            liveViewTimer.Tick += new EventHandler(liveViewTimer_Tick);
            liveViewTimer.Interval = 1000 / 30;
            // Initialize Nikon manager
            manager = new NikonManager("Type0009.md3");
            manager.DeviceAdded += new DeviceAddedDelegate(manager_DeviceAdded);
            manager.DeviceRemoved += new DeviceRemovedDelegate(manager_DeviceRemoved);
            #endregion

            #region Stage initialization
            // Disable buttons
            ToggleStageButtons(false);
            // Check connected hardware
            string szResult = CU30obj.m_CU30Open(0).ToString();
            if (szResult.Length > 5)
            {
                this.stageLabel.Text = szResult;
            }
            else
            {
                this.stageLabel.Text = "Connected";
                ToggleStageButtons(true);

            }
            #endregion

            #region Fiber initialization
            // Serial number of hardware component in use 
            const string serialNumber = "27505289";
            // Disable buttons
            ToggleFiberButtons(false);
            // Initialize fiber controller
            initializeFiber(serialNumber);
            #endregion
        }

        #region Camera controls
        private void liveViewButton_Click(object sender, EventArgs e)
        {
            if (device == null)
            {
                return;
            }
            if (device.LiveViewEnabled)
            {
                device.LiveViewEnabled = false;
                liveViewTimer.Stop();
                pictureBox.Image = null;
            }
            else
            {
                device.LiveViewEnabled = true;
                liveViewTimer.Start();
            }
        }
        private void captureButton_Click(object sender, EventArgs e)
        {
            if (device == null)
            {
                return;
            }
            ToggleCameraButtons(false);
            try
            {
                device.Capture();
            }
            catch (NikonException ex)
            {
                MessageBox.Show(ex.Message);
                ToggleCameraButtons(true);
            }
            pictureBox.Image = null;
        }
        #endregion

        #region Camera control functions
        protected override void OnClosing(CancelEventArgs e)
        {
            // Disable live view (in case it's enabled)
            if (device != null)
            {
                device.LiveViewEnabled = false;
            }
            // Shut down the Nikon manager
            manager.Shutdown();
            base.OnClosing(e);
        }

        void manager_DeviceAdded(NikonManager sender, NikonDevice device)
        {
            this.device = device;
            // Set the device name
            cameraLabel.Text = device.Name;
            // Enable buttons
            ToggleCameraButtons(true);
            // Hook up device capture events
            device.ImageReady += new ImageReadyDelegate(device_ImageReady);
            device.CaptureComplete += new CaptureCompleteDelegate(device_CaptureComplete);
        }

        void manager_DeviceRemoved(NikonManager sender, NikonDevice device)
        {
            this.device = null;
            // Stop live view timer
            liveViewTimer.Stop();
            // Clear device name
            cameraLabel.Text = "No Camera";
            // Disable buttons
            ToggleCameraButtons(false);
            // Clear live view picture
            pictureBox.Image = null;
        }

        void liveViewTimer_Tick(object sender, EventArgs e)
        {
            // Get live view image
            NikonLiveViewImage image = null;
            try
            {
                image = device.GetLiveViewImage();
            }
            catch (NikonException)
            {
                liveViewTimer.Stop();
            }
            // Set live view image on picture box
            if (image != null)
            {
                MemoryStream stream = new MemoryStream(image.JpegBuffer);
                pictureBox.Image = Image.FromStream(stream);
            }
        }

        void device_ImageReady(NikonDevice sender, NikonImage image)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = (image.Type == NikonImageType.Jpeg) ?
                "Jpeg Image (*.jpg)|*.jpg" :
                "Nikon NEF (*.nef)|*.nef";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(dialog.FileName, FileMode.Create, FileAccess.Write))
                {
                    stream.Write(image.Buffer, 0, image.Buffer.Length);
                }
            }
        }

        void device_CaptureComplete(NikonDevice sender, int data)
        {
            // Re-enable buttons when the capture completes
            ToggleCameraButtons(true);
        }

        void ToggleCameraButtons(bool enabled)
        {
            this.captureButton.Enabled = enabled;
            this.liveViewButton.Enabled = enabled;
        }
        #endregion

        #region Stage controls
        private void xPlusButton_Click(object sender, EventArgs e)
        {
            int vel = (int)this.xVelocityNumericUpDown.Value;
            int steps = (int)this.xStepsNumericUpDown.Value;
            CU30obj.m_CU30Step(1, vel, steps);
        }

        private void xMinusButton_Click(object sender, EventArgs e)
        {
            int vel = (int)this.xVelocityNumericUpDown.Value;
            int steps = (int)this.xStepsNumericUpDown.Value;
            CU30obj.m_CU30Step(1, -vel, steps);
        }

        private void yPlusButton_Click(object sender, EventArgs e)
        {
            int vel = (int)this.yVelocityNumericUpDown.Value;
            int steps = (int)this.yStepsNumericUpDown.Value;
            CU30obj.m_CU30Step(2, vel, steps);
        }

        private void yMinusButton_Click(object sender, EventArgs e)
        {
            int vel = (int)this.yVelocityNumericUpDown.Value;
            int steps = (int)this.yStepsNumericUpDown.Value;
            CU30obj.m_CU30Step(2, -vel, steps);
        }

        private void zPlusButton_Click(object sender, EventArgs e)
        {
            int vel = (int)this.zVelocityNumericUpDown.Value;
            int steps = (int)this.zStepsNumericUpDown.Value;
            CU30obj.m_CU30Step(3, vel, steps);
        }

        private void zMinusButton_Click(object sender, EventArgs e)
        {
            int vel = (int)this.zVelocityNumericUpDown.Value;
            int steps = (int)this.zStepsNumericUpDown.Value;
            CU30obj.m_CU30Step(3, -vel, steps);
        }
        #endregion

        #region Stage control functions
        void ToggleStageButtons(bool enabled)
        {
            this.xPlusButton.Enabled = enabled;
            this.xMinusButton.Enabled = enabled;
            this.yPlusButton.Enabled = enabled;
            this.yMinusButton.Enabled = enabled;
            this.zPlusButton.Enabled = enabled;
            this.zMinusButton.Enabled = enabled;
            this.xVelocityNumericUpDown.Enabled = enabled;
            this.xStepsNumericUpDown.Enabled = enabled;
            this.yVelocityNumericUpDown.Enabled = enabled;
            this.yStepsNumericUpDown.Enabled = enabled;
            this.zVelocityNumericUpDown.Enabled = enabled;
            this.zStepsNumericUpDown.Enabled = enabled;
        }

        #endregion

        #region Fiber control functions
        private void jogSizeStepFromTextBox(string jogSizeText)
        {
            decimal step;
            if (Decimal.TryParse(jogSizeText, out step))
            {
                _kCubeDCServoMotor.SetJogStepSize(step);
                return;
            }
            else
            {
                MessageBox.Show("Invalid jog step size");
                return;
            }
        }

        private void initializeFiber(string serial)
        {
            try
            {
                // Instructs the DeviceManager to build and maintain the list of devices connected.
                DeviceManagerCLI.BuildDeviceList();
            }
            catch (Exception)
            {
                this.fiberLabel.Text = "Not connected";
                return;
            }

            try
            {
                _kCubeDCServoMotor = KCubeDCServo.CreateKCubeDCServo(serial);
                // Establish a connection with the device.
                _kCubeDCServoMotor.Connect(serial);
            }
            catch (Exception)
            {
                this.fiberLabel.Text = "Unable to connect";
                return;
            }

            try
            {
                // Wait for the device settings to initialize. We ask the device to
                // throw an exception if this takes more than 5000ms (5s) to complete.
                _kCubeDCServoMotor.WaitForSettingsInitialized(5000);
                // Initialize the DeviceUnitConverter object required for real world unit parameters.
                _kCubeDCServoMotor.LoadMotorConfiguration(_kCubeDCServoMotor.DeviceID, DeviceConfiguration.DeviceSettingsUseOptionType.UseFileSettings);
                // This starts polling the device at intervals of 250ms (0.25s).
                _kCubeDCServoMotor.StartPolling(250);
                // We are now able to enable the device for commands.
                _kCubeDCServoMotor.EnableDevice();
                // Enable buttons and contros
                ToggleFiberButtons(true);
                this.fiberLabel.Text = "Connected";
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to initialize fiber controller\n" + ex);
                return;
            }
        }

        private void ToggleFiberButtons(bool enable)
        {
            this.jogSizeTextBox.Enabled = enable;
            this.upButton.Enabled = enable;
            this.downButton.Enabled = enable;
            return;
        }
        #endregion

        #region Fiber controls
        private void upButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Throw exeption if it takes more than 5s to jog
                _kCubeDCServoMotor.MoveJog(MotorDirection.Backward, 3000);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to move jog" + ex);
                return;
            }
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Throw exeption if it takes more than 5s to jog
                _kCubeDCServoMotor.MoveJog(MotorDirection.Forward, 3000);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to move jog" + ex);
                return;
            }
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            try
            {
                jogSizeStepFromTextBox(jogSizeTextBox.Text);
                jogSizeTextBox.Font = new Font(jogSizeTextBox.Font, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to set jog step size" + ex);
                return;
            }
        }
        #endregion
    }
}
