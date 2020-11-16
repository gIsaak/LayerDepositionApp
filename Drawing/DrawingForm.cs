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


namespace Drawing
{
    public partial class DrawingForm : Form
    {
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
        }

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

        private void startLiveViewButton_Click(object sender, System.EventArgs e)
        {
            if (capture != null)
            {
                if (captureInProgress)
                {  //stop the capture
                    startLiveViewButton.Text = "Start Capture";
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
        }

        private void imageBox_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            this.clickedPoint = me.Location;
            this.mouseTextBox.Text = me.Location.ToString();
            // TODO - WTF is wrong with this
        }

        private double GetPointLineDistance(LineSegment2D line, Point point)
        {
            int x1 = line.P1.X, y1 = line.P1.Y;
            int x2 = line.P2.X, y2 = line.P2.Y;
            int x0 = point.X, y0 = point.Y;
            double num = Math.Abs((y2 - y1)*x0 - (x2 - x1)*y0 + x2*y1 - y2*x1);
            double den = Math.Sqrt((y2 - y1)*(y2 - y1) + (x2 - x1)*(x2 - x1));
            return num / den;
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
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
        }

    }
}
