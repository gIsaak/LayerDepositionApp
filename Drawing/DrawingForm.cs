using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Input;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.Util;
using Nikon;
using System.ComponentModel;
using System.IO;
using System.Drawing.Imaging;

namespace Drawing
{
    public partial class DrawingForm : Form
    {
        // Nikon
        private NikonManager manager;
        private NikonDevice device;
        private Timer liveViewTimer;
        // Emgu
        private VideoCapture capture = null;
        private bool captureInProgress;
        private Mat frame = new Mat();
        private Mat grayFrame = new Mat();
        private Mat smallGrayFrame = new Mat();
        private Mat smoothedGrayFrame = new Mat();
        private Mat contour = new Mat();
        private Point clickedPoint;
        private bool drawing = false;
        private List<LineSegment2D> drawnLines = new List<LineSegment2D>();

        public DrawingForm()
        {
            InitializeComponent();
            #region Initialize Nikon
            // Disable buttons
            ToggleButtons(false);

            // Initialize live view timer
            liveViewTimer = new Timer();
            liveViewTimer.Tick += new EventHandler(liveViewTimer_Tick);
            liveViewTimer.Interval = 1000 / 30;

            // Initialize Nikon manager
            manager = new NikonManager("Type0009.md3");
            manager.DeviceAdded += new DeviceAddedDelegate(manager_DeviceAdded);
            manager.DeviceRemoved += new DeviceRemovedDelegate(manager_DeviceRemoved);
            #endregion

            /*
            #region Initialize Emgu
            CvInvoke.UseOpenCL = false;
            try
            {
                capture = new VideoCapture();
                capture.ImageGrabbed += ProcessFrame;
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }
            #endregion
            */
        }
        /*
        private void ProcessFrame(object sender, EventArgs arg)
        {
            if (capture != null && capture.Ptr != IntPtr.Zero)
            {
                capture.Retrieve(frame, 0);
                
                #region Contour
                double cannyThreshold = 200;//150.0;
                double cannyThresholdLinking = 100;//75.0;
                CvInvoke.CvtColor(frame, grayFrame, ColorConversion.Bgr2Gray);
                CvInvoke.PyrDown(grayFrame, smallGrayFrame);
                CvInvoke.PyrUp(smallGrayFrame, smoothedGrayFrame);
                CvInvoke.Canny(grayFrame, contour, cannyThreshold, cannyThresholdLinking);
                #endregion

                imageBox.Image = frame;
                // Draw line
                if (this.drawing)
                {
                    foreach (LineSegment2D line in this.drawnLines)
                        CvInvoke.Line(frame, line.P1, line.P2, new Bgr(Color.Green).MCvScalar, 2);
                    CvInvoke.Circle(frame, clickedPoint, 5, new Bgr(Color.Red).MCvScalar);
                }
                
            }
        }
        */

        private void startLiveViewButton_Click(object sender, System.EventArgs e)
        {
            /*
            if (capture != null)
            {
                if (captureInProgress)
                {  //stop the capture
                    startLiveViewButton.Text = "Start Live View";
                    capture.Pause();
                }
                else
                {
                    //start the capture
                    startLiveViewButton.Text = "Stop";
                    capture.Start();
                }
                captureInProgress = !captureInProgress;
            }
            */

            if (device == null)
            {
                return;
            }
            if (device.LiveViewEnabled)
            {
                device.LiveViewEnabled = false;
                liveViewTimer.Stop();
                imageBox.Image = null;
            }
            else
            {
                device.LiveViewEnabled = true;
                liveViewTimer.Start();
            }
        }

        private void imageBox_Click(object sender, EventArgs e)
        {
            /*
            MouseEventArgs me = (MouseEventArgs)e;
            this.clickedPoint = me.Location;
            this.mouseTextBox.Text = me.Location.ToString();
            // TODO - WTF is wrong with this
            */
        }

        /*
        private double GetPointLineDistance(LineSegment2D line, Point point)
        {
            int x1 = line.P1.X, y1 = line.P1.Y;
            int x2 = line.P2.X, y2 = line.P2.Y;
            int x0 = point.X, y0 = point.Y;
            double num = Math.Abs((y2 - y1)*x0 - (x2 - x1)*y0 + x2*y1 - y2*x1);
            double den = Math.Sqrt((y2 - y1)*(y2 - y1) + (x2 - x1)*(x2 - x1));
            return num / den;
        }
        */

        private void drawButton_Click(object sender, EventArgs e)
        {
            /*
            this.drawing = true;
            if (this.clickedPoint.IsEmpty == false)
            {
                LineSegment2D[] lines = CvInvoke.HoughLinesP(
                    contour,
                    1, //Distance resolution in pixel-related units
                    Math.PI / 180.0, //Angle resolution measured in radians.
                    70, //threshold
                    10, //min Line width
                    250); //gap between lines

                var pointLineDist = new List<double>();
                foreach (LineSegment2D line in lines)
                    pointLineDist.Add(GetPointLineDistance(line, clickedPoint));
                var maxIndex = pointLineDist.IndexOf(pointLineDist.Max());
                this.drawnLines.Add(lines[maxIndex]);

            }
            else
            {
                MessageBox.Show("Click on image to select line");
            }
            */
        }

        #region Nikon controls
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

            // Enable buttons
            ToggleButtons(true);

            // Hook up device capture events
            device.ImageReady += new ImageReadyDelegate(device_ImageReady);
            device.CaptureComplete += new CaptureCompleteDelegate(device_CaptureComplete);
        }

        void manager_DeviceRemoved(NikonManager sender, NikonDevice device)
        {
            this.device = null;

            // Stop live view timer
            liveViewTimer.Stop();

            // Disable buttons
            ToggleButtons(false);

            // Clear live view picture
            imageBox.Image = null;
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
                // Uncomment to directly display memory stream on pictureBox (NOT imageBox)
                //pictureBox.Image = Image.FromStream(stream);

                //inputImage type is System.Drawing.Image
                Bitmap bitmapImage = new Bitmap(Image.FromStream(stream));

                Rectangle rectangle = new Rectangle(0, 0, bitmapImage.Width, bitmapImage.Height);//System.Drawing
                BitmapData bmpData = bitmapImage.LockBits(rectangle, ImageLockMode.ReadWrite, bitmapImage.PixelFormat);//System.Drawing.Imaging

                Image<Bgr, byte> outputImage = new Image<Bgr, byte>(bitmapImage.Width, bitmapImage.Height, bmpData.Stride, bmpData.Scan0);//(IntPtr)

                imageBox.Image = outputImage;
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
            ToggleButtons(true);
        }

        void ToggleButtons(bool enabled)
        {
            this.startLiveViewButton.Enabled = enabled;
        }
        #endregion
    }
}
