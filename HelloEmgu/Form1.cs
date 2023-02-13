using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloEmgu
{
    public partial class Form1 : Form
    {
        private VideoCapture _capture;
        private Thread _captureThread;
        private int _threshold = 150;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _capture = new VideoCapture(1);
            _captureThread = new Thread(DisplayWebcam);
            _captureThread.Start();
            thresholdTrackbar.Value = _threshold;
        }

        private void DisplayWebcam()
        {
            while(_capture.IsOpened)
            {
                //frame maintnance
                Mat frame = _capture.QueryFrame();

                //Resize to Picturebox aspect ratio
                int newHeight = (frame.Size.Height * emguPictureBox.Size.Width) / frame.Size.Width;
                Size newSize = new Size(emguPictureBox.Size.Width, newHeight);
                CvInvoke.Resize(frame, frame, newSize);

                //display the image in box
                emguPictureBox.Image = frame.ToBitmap();

                Mat frameGrey = new Mat();
                CvInvoke.CvtColor(frame, frameGrey, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
                CvInvoke.Threshold(frameGrey, frameGrey, _threshold, 255, Emgu.CV.CvEnum.ThresholdType.Binary);
                binaryPictureBox.Image = frameGrey.ToBitmap();

                // White pixel count code
                int whitePixelMostLeft = 0;
                int whitePixelLeft = 0;
                int whitePixelMiddle = 0;
                int whitePixelRight = 0;
                int whitePixelMostRight = 0;
                Image<Gray, byte> img2 = frameGrey.ToImage<Gray, byte>();
                //slice 1 - Most Left
                for (int x = 0; x < frameGrey.Width / 5; x++)
                {
                    for (int y = 0; y < frameGrey.Height; y++)
                    {
                        if (img2.Data[y, x, 0] == 255) whitePixelMostLeft++;
                    }
                }

                Invoke(new Action(() =>
                {
                    whitePixelsLFLbl.Text = $"{whitePixelMostLeft} White Pixels in FL";
                }));
                //Slice 1 - Most Left

                // Slice 2 - Left
                for (int Lx = frameGrey.Width / 5; Lx < (2 * frameGrey.Width) / 5; Lx++)
                {
                    for (int Ly = 0; Ly < frameGrey.Height; Ly++)
                    {
                        if (img2.Data[Ly, Lx, 0] == 255) whitePixelLeft++; 
                    }
                }
                Invoke(new Action(() =>
                {
                    whitePixelsLLbl.Text = $"{whitePixelLeft} White Pixels in L";
                }));
                // Slice 2 - Left

                //Slice 3 - Middle
                for (int Mx = (2 * frameGrey.Width) / 5; Mx < (3 * frameGrey.Width) / 5; Mx++)
                {
                    for (int My = 0; My < frameGrey.Height; My++)
                    {
                        if (img2.Data[My, Mx, 0] == 255) whitePixelMiddle++; 
                    }
                }
                Invoke(new Action(() =>
                {
                    whitePixelsMLbl.Text = $"{whitePixelMiddle} White Pixels in M";
                }));
                //Slice 3 - Middle

                //slice 4 - Right
                for (int Rx = (3 * frame.Width) / 5; Rx < (4 * frame.Width) / 5; Rx++)
                {
                    for (int Ry = 0; Ry < frame.Height; Ry++)
                    {
                        if (img2.Data[Ry, Rx, 0] == 255) whitePixelRight++;
                    }
                }
                Invoke(new Action(() =>
                {
                    whitePixelsRLbl.Text = $"{whitePixelRight} White Pixels in R";
                }));
                //Slice 4 - Right

                //slice 5 - Far Right
                for (int MRx = (4 * frameGrey.Width) / 5; MRx < frameGrey.Width; MRx++)
                {
                    for (int MRy = 0; MRy < frameGrey.Height; MRy++)
                    {
                        if (img2.Data[MRy, MRx, 0] == 255) whitePixelMostRight++; 
                    }
                }
               
                Invoke(new Action(() =>
                {
                    whitePixelsRFLbl.Text = $"{whitePixelMostRight} White Pixels in MR";
                }));
                //Slice 5 - Far Right
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // terminate the image processing thread to avoid orphaned processes
            _captureThread.Abort();
        }

        private void thresholdTrackbar_ValueChanged(object sender, EventArgs e)
        {
            _threshold = thresholdTrackbar.Value;
        }
    }
}
