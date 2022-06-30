using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using System.IO;

namespace Contact_Tracing_Form
{
    public partial class pageQRScanner : Form
    {
        public pageQRScanner()
        {
            InitializeComponent();
        }


        FilterInfoCollection filterInfo;
        VideoCaptureDevice captureDevice;
        private void pageQRScanner_Load(object sender, EventArgs e)
        {
            filterInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filter in filterInfo)
            {
                cameraChoice.Items.Add(filter.Name);
            }
            cameraChoice.SelectedIndex = 0;
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            File.Delete(@"C:\Users\mjae0\OneDrive\Documents\University\Freshmen\secondSem\OOP\Contact Tracing Form\Data\databaseQR.txt");
            captureDevice = new VideoCaptureDevice(filterInfo[cameraChoice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer.Start();
        }
        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            cameraFeed.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void closingQR(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
            {
                captureDevice.Stop();
            }
        }

        private void timerFunc(object sender, EventArgs e)
        {
            

            
            

            if (cameraFeed.Image != null)
            {
                BarcodeReader qrScanner = new BarcodeReader();
                Result result = qrScanner.Decode((Bitmap)cameraFeed.Image);


                if (result != null)
                {
                    StreamWriter writer = new StreamWriter(@"C:\Users\mjae0\OneDrive\Documents\University\Freshmen\secondSem\OOP\Contact Tracing Form\Data\databaseQR.txt", true);
                    writer.Write(result.ToString());
                    writer.Close();
                    btnBack.PerformClick();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pageContactTracing pageContactTracing = new pageContactTracing();
            pageContactTracing.autofill();
            pageContactTracing.Show();
            this.Hide();
        }
    }
}
