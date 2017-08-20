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
    public partial class MainWindow : Form
    {
        private Settings Settings { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            InitializeSettings();
        }

        private void InitializeSettings()
        {
            Settings = new Settings()
            {
                ShowTime = 2,
                Cooldown = 5,
                BaseDirectory = @"C:\Users\Jesper\Pictures\BaseImages",
                CameraDirectory = @"C:\Users\Jesper\Pictures\CImages",
                PictureDisplayMode = PictureBoxSizeMode.StretchImage
            };
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            SlideshowWindow slideShow = new SlideshowWindow(Settings);
            slideShow.StartPosition = FormStartPosition.Manual;
            slideShow.Location = Screen.AllScreens[Settings.DisplayScreen].WorkingArea.Location;
            slideShow.Start();
            slideShow.ShowDialog();
        }

        private void settings_button_Click(object sender, EventArgs e)
        {
            SettingsDialog settingsDlg = new SettingsDialog(Settings);
            if(settingsDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Settings = settingsDlg.Settings;
            }
        }
    }
}
