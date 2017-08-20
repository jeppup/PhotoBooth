using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WPD;

namespace PhotoBooth.Entities
{
    public class Settings
    {
        public int ShowTime { get; set; }
        public int Cooldown { get; set; }
        public string BaseDirectory { get; set; }
        public string CameraDirectory { get; set; }
        public PictureBoxSizeMode PictureDisplayMode { get; set; }
        public int DisplayScreen { get; set; }
        public PortableDevice ExternalDevice { get; set; }
    }
}
