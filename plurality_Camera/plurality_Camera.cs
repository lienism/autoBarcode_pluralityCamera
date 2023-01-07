using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace plurality_Camera
{
    public partial class plurality_Camera : Form
    {
        FilterInfoCollection videoDevices;
        private Stopwatch stopWatch = null;
        public plurality_Camera()
        {
            InitializeComponent();
            
            camera1FpsLabel.Text = string.Empty;
            camera2FpsLabel.Text = string.Empty;
            camera3FpsLabel.Text = string.Empty;
            Camera1_Barcode_Label.Text = string.Empty;
            Camera2_Barcode_Label.Text = string.Empty;
            Camera3_Barcode_Label.Text = string.Empty;
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (videoDevices.Count == 0)
                {
                    throw new Exception();
                }
                for (int i = 1, n = videoDevices.Count; i <= n; i++)
                {
                    string cameraName = i + " : " + videoDevices[i - 1].Name;

                    camera1Combo.Items.Add(cameraName);
                    camera2Combo.Items.Add(cameraName);
                    camera3Combo.Items.Add(cameraName);
                }
                switch (videoDevices.Count)
                {
                    case 1:
                        camera2Combo.Items.Clear();
                        camera3Combo.Items.Clear();
                        camera2Combo.Items.Add("Only one camera found");
                        camera3Combo.Items.Add("Only one camera found");
                        camera2Combo.SelectedIndex = 0;
                        camera3Combo.SelectedIndex = 0;
                        camera2Combo.Enabled = false;
                        camera3Combo.Enabled = false;
                        break;
                    case 2:
                        camera3Combo.Items.Clear();
                        camera3Combo.Items.Add("Only two camera found");
                        camera3Combo.SelectedIndex = 0;
                        camera3Combo.Enabled = false;
                        break;
                    case 3:
                        camera2Combo.SelectedIndex = 1;
                        camera3Combo.SelectedIndex = 1;
                        break;
                    default:
                        break;
                }
            }
            catch
            {
                startButton.Enabled = false;

                camera1Combo.Items.Add("No cameras found");
                camera2Combo.Items.Add("No cameras found");
                camera3Combo.Items.Add("No cameras found");

                camera1Combo.SelectedIndex = 0;
                camera2Combo.SelectedIndex = 0;
                camera3Combo.SelectedIndex = 0;

                camera1Combo.Enabled = false;
                camera2Combo.Enabled = false;
                camera3Combo.Enabled = false;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartCameras();

            startButton.Enabled = false;
            stopButton.Enabled = true;
        }
        private void StartCameras()
        {
            // create first video source
            if (camera1Combo.SelectedIndex != -1)
            {
                VideoCaptureDevice videoSource1 = new VideoCaptureDevice(videoDevices[camera1Combo.SelectedIndex].MonikerString);
                //videoSource1.DesiredFrameRate = 10;
                videoSourcePlayer1.VideoSource = videoSource1;
                videoSourcePlayer1.Start();
            }


            // create second video source
            if (camera2Combo.Enabled == true)
            {
                if (camera2Combo.SelectedIndex != -1)
                {
                    System.Threading.Thread.Sleep(500);

                    VideoCaptureDevice videoSource2 = new VideoCaptureDevice(videoDevices[camera2Combo.SelectedIndex].MonikerString);
                    //videoSource2.DesiredFrameRate = 10;

                    videoSourcePlayer2.VideoSource = videoSource2;
                    videoSourcePlayer2.Start();
                }
            }
            if (camera3Combo.Enabled == true)
            {
                if (camera3Combo.SelectedIndex != -1)
                {
                    System.Threading.Thread.Sleep(500);

                    VideoCaptureDevice videoSource3 = new VideoCaptureDevice(videoDevices[camera3Combo.SelectedIndex].MonikerString);
                    //videoSource3.DesiredFrameRate = 10;

                    videoSourcePlayer3.VideoSource = videoSource3;
                    videoSourcePlayer3.Start();
                }
            }
           

            // reset stop watch
            stopWatch = null;
            // start timer
            timer.Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            StopCameras();

            startButton.Enabled = true;
            stopButton.Enabled = false;

            camera1FpsLabel.Text = string.Empty;
            camera2FpsLabel.Text = string.Empty;
            camera3FpsLabel.Text = string.Empty;
        }
        private void StopCameras()
        {
            timer.Stop();

            videoSourcePlayer1.SignalToStop();
            videoSourcePlayer2.SignalToStop();
            videoSourcePlayer3.SignalToStop();

            videoSourcePlayer1.WaitForStop();
            videoSourcePlayer2.WaitForStop();
            videoSourcePlayer3.WaitForStop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            IVideoSource videoSource1 = videoSourcePlayer1.VideoSource;
            IVideoSource videoSource2 = videoSourcePlayer2.VideoSource;
            IVideoSource videoSource3 = videoSourcePlayer3.VideoSource;


            int framesReceived1 = 0;
            int framesReceived2 = 0;
            int framesReceived3 = 0;
            int framesReceived4 = 0;

            // get number of frames for the last second
            if (videoSource1 != null)
            {
                framesReceived1 = videoSource1.FramesReceived;
            }

            if (videoSource2 != null)
            {
                framesReceived2 = videoSource2.FramesReceived;
            }

            if (videoSource3 != null)
            {
                framesReceived3 = videoSource3.FramesReceived;
            }

            if (stopWatch == null)
            {
                stopWatch = new Stopwatch();
                stopWatch.Start();
            }
            else
            {
                stopWatch.Stop();

                float fps1 = 1000.0f * framesReceived1 / stopWatch.ElapsedMilliseconds;
                float fps2 = 1000.0f * framesReceived2 / stopWatch.ElapsedMilliseconds;
                float fps3 = 1000.0f * framesReceived3 / stopWatch.ElapsedMilliseconds;
                float fps4 = 1000.0f * framesReceived4 / stopWatch.ElapsedMilliseconds;

                camera1FpsLabel.Text = fps1.ToString("F2") + " fps";
                camera2FpsLabel.Text = fps2.ToString("F2") + " fps";
                camera3FpsLabel.Text = fps3.ToString("F2") + " fps";

                stopWatch.Reset();
                stopWatch.Start();
            }
        }

        private void videoSourcePlayer1_NewFrame(object sender, ref Bitmap image)
        {
            Save_Bitmap(image , "Top");
        }

        private void videoSourcePlayer2_NewFrame(object sender, ref Bitmap image)
        {
            Save_Bitmap(image, "Left");
        }

        private void videoSourcePlayer3_NewFrame(object sender, ref Bitmap image)
        {
            Save_Bitmap(image, "Right");
        }
        public void Save_Bitmap(Bitmap bmp , String direction)
        {
            DateTime dt = DateTime.Now;
            
            String Filename = direction + "_" + dt.Year + dt.Month + dt.Day + dt.Hour + dt.Minute + dt.Second + ".jpg";
            bmp.Save("./Barcode/" + Filename);
        }
    }
}
