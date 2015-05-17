/*using System;
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
    // Thread class to be able to display the progress
    // using the static label
    class ScanThread
    {
        MediaDetClass md;
        string fileName;
        string storagePath;
        float interval;
        public Thread t;
        int counter;
        public ScanThread(string s, string f, float ival)
        {
            storagePath = s;
            fileName = f;
            interval = ival;
            t = new Thread(new ThreadStart(this.Scan));
            t.Start();
        }
        void Scan()
        {
            md = new MediaDetClass();
            Image img;
            md.Filename = fileName;
            md.CurrentStream = 0;
            int len = (int)md.StreamLength;
            for (float i = 0.0f; i < len; i = i + interval)
            {
                counter++;
                string fBitmapName = storagePath + Path.GetFileNameWithoutExtension(fileName)
                  + "_" + counter.ToString();
                md.WriteBitmapBits(i, 320, 240, fBitmapName + ".bmp");
                img = Image.FromFile(fBitmapName + ".bmp");
                img.Save(fBitmapName + ".jpg", ImageFormat.Jpeg);
                img.Dispose();
                System.IO.File.Delete(fBitmapName + ".bmp");
            }
        }
    }
}*/
