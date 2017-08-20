using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhotoBooth.Entities;

namespace PhotoBooth
{
    public partial class SlideshowWindow : Form
    {
        private Settings Settings { get; set; }
        private PhotoIterator Iterator { get; set; }
        private Task ImageSwapper { get; set; }
        private bool IsRunning = false;

        public SlideshowWindow(Settings s)
        {
             
            InitializeComponent();
            Settings = s;
            Iterator = new PhotoIterator(Settings);
            ResizeWindow();

        }

        private void ResizeWindow()
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            pictureBox.Bounds = this.ClientRectangle;
            pictureBox.Dock = DockStyle.None;
            pictureBox.SizeMode = Settings.PictureDisplayMode;
            Invalidate();
        }

        public void Start()
        {
            IsRunning = true;
            ImageSwapper = Task.Factory.StartNew(RunLoop);
        }

        private void RunLoop()
        {
            while(IsRunning)
            {
                try
                {
                    var image = Iterator.GetNextImage();
                    this.Invoke(new Action(() => pictureBox.Image = image));
                    Task.Delay(Settings.ShowTime * 1000).Wait();
                }
                catch(Exception ex)
                {

                }
            }

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            if(ImageSwapper != null)
            {
                IsRunning = false;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
                this.Close();
            }
        }
    }
}
