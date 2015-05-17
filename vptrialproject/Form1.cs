using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Data;
using System.Collections;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;
using DexterLib;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string filename;           //used to save the video file name 
        string storagePath;        //used for the path where we save files
        MediaDetClass md;          //needed to extract pictures
        static int counter = 0;    //to generate different file names
        float interval = 1.0f;     //default time interval
        
        public Form1()
        {
            InitializeComponent();
            //initialize a few properties
            tracker.Minimum = tracker.Maximum = 0;
            this.MaximizeBox = false;
           // miNormalSpeed.Checked = true;
            storagePath = Application.StartupPath + "\\tmp\\";

            //if the storage directory doesn't exist we create it
            if (!Directory.Exists(storagePath))
                Directory.CreateDirectory(storagePath);
        }


        private void upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                //place the file path in textbox
                this.url_movie.Text = dlg.FileName;
            {
                try
                {
                    filename = dlg.FileName;
                    this.Text = Path.GetFileName(dlg.FileName);

                    //create the MediaDetClass and set its properties
                    md = new MediaDetClass();
                    md.Filename = filename;
                    md.CurrentStream = 0;
                    int len = (int)md.StreamLength;

         
                    //a file then use it to fill the picture box
                    counter++;
                    string fBitmapName = storagePath + counter.ToString() + ".bmp";
                    md.WriteBitmapBits(0, 320, 240, fBitmapName);
                    images.Image = new Bitmap(fBitmapName);

                }
                catch (Exception) { MessageBox.Show("Coulnd't open movie file"); }
            }

        }

        private void play_Click(object sender, EventArgs e)
        {
            //playing the video
            axWindowsMediaPlayer1.URL = url_movie.Text;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void tracker_ValueChanged(object sender, EventArgs e)
        {
            if (md == null) return;
            images.Image.Dispose();
            label1.Text = "Current Position: " + tracker.Value.ToString();
            string BitmapName = storagePath + "tmp" + counter.ToString() + ".bmp";
            counter++;
            md.WriteBitmapBits(tracker.Value, 320, 240, BitmapName);
            images.Image = new Bitmap(BitmapName);
        }

       /* private void save_Click(object sender, EventArgs e)
        {
            counter++;
            images.Image.Dispose();
            string fBitmapName = storagePath + Path.GetFileNameWithoutExtension(filename)
              + "_" + counter.ToString();
            md.WriteBitmapBits(tracker.Value, 320, 240, fBitmapName + ".bmp");
            images.Image = new Bitmap(fBitmapName + ".bmp");
            //save the picture as jpeg
            Image img = Image.FromFile(fBitmapName + ".bmp");
            img.Save(fBitmapName + ".jpg", ImageFormat.Jpeg);
            img.Dispose();
        }*/
        
    }
}
