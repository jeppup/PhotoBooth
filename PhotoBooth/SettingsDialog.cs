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
using WPD;

namespace PhotoBooth
{
    public partial class SettingsDialog : Form
    {
        public Settings Settings { get; set; }
        public PortableDeviceCollection DeviceCollection = new PortableDeviceCollection();

        public SettingsDialog(Settings s)
        {
            Settings = s;
            InitializeComponent();
            InitializeDisplayModes();
            InitializeDisplayScreens();
            InitializeDeviceManager();
            PopulateFields();
        }

        private void InitializeDeviceManager()
        {
            DeviceCollection.Refresh();
            foreach(var device in DeviceCollection.Devices)
            {
                device.Connect();
                ExternalDevice_dropdown.Items.Add(device.FriendlyName);
                device.Disconnect();
            }
        }

        private void InitializeDisplayModes()
        {
            var displayModes = Enum.GetNames(typeof(PictureBoxSizeMode));
            foreach(var displayMode in displayModes)
            {
                DisplayMode_dropdown.Items.Add(displayMode);
            }
        }

        private void InitializeDisplayScreens()
        {
            foreach(var display in Screen.AllScreens)
            {
                DisplayScreen_dropdown.Items.Add(display.DeviceName);
            }
        }

        private void AssignValues()
        {
            Settings.ShowTime = int.Parse(DisplayTime_textbox.Text);
            Settings.Cooldown = int.Parse(Cooldown_textbox.Text);
            Settings.BaseDirectory = BaseImageDirectory_textbox.Text;
            Settings.CameraDirectory = CameraImagesDirectory_textbox.Text;
            Settings.PictureDisplayMode =  (PictureBoxSizeMode)Enum.Parse(typeof(PictureBoxSizeMode), (string)DisplayMode_dropdown.SelectedItem);
            Settings.DisplayScreen = DisplayScreen_dropdown.SelectedIndex;
            Settings.ExternalDevice = DeviceCollection.Devices[ExternalDevice_dropdown.SelectedIndex];
        }

        private void PopulateFields()
        {
            var displayMode = Enum.GetName(typeof(PictureBoxSizeMode), Settings.PictureDisplayMode);
            var displayScreen = Settings.DisplayScreen;

            this.DisplayTime_textbox.Text = Settings.ShowTime.ToString();
            this.Cooldown_textbox.Text = Settings.Cooldown.ToString();
            this.BaseImageDirectory_textbox.Text = Settings.BaseDirectory;
            this.CameraImagesDirectory_textbox.Text = Settings.CameraDirectory;
            this.DisplayMode_dropdown.SelectedItem = displayMode;
            if (DisplayScreen_dropdown.Items.Count > displayScreen)
            {
                DisplayScreen_dropdown.SelectedIndex = displayScreen;
            }
            else
            {
                DisplayScreen_dropdown.SelectedIndex = 0;
            }
            if(ExternalDevice_dropdown.Items.Count != 0)
            {
                ExternalDevice_dropdown.SelectedIndex = 0;
            }
        }

        private void BaseImageDirectory_modifyButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();
            if(browser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                BaseImageDirectory_textbox.Text = browser.SelectedPath;
            }
        }

        private void CameraImagesDirectory_modifyButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();
            if (browser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CameraImagesDirectory_textbox.Text = browser.SelectedPath;
            }
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            AssignValues();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
