using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPD
{
    public class PortableDeviceFolder : PortableDeviceObject
    {
        public PortableDeviceFolder(string id, string name)
            : base(id, name)
        {
            this.Files = new List<PortableDeviceObject>();
        }

        public List<PortableDeviceObject> Files { get; set; }
    }
}
