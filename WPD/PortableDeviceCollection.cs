using PortableDeviceApiLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPD
{
    public class PortableDeviceCollection
    {
        private readonly PortableDeviceManager _deviceManager;
        public List<PortableDevice> Devices { get; set; }

        public PortableDeviceCollection()
        {
            this._deviceManager = new PortableDeviceManager();
            Devices = new List<PortableDevice>();
        }

        public void Refresh()
        {
            this._deviceManager.RefreshDeviceList();

            // Determine how many WPD devices are connected
            var deviceIds = new string[1];
            uint count = 1;
            this._deviceManager.GetDevices(ref deviceIds[0], ref count);

            // Retrieve the device id for each connected device
            deviceIds = new string[count];
            this._deviceManager.GetDevices(ref deviceIds[0], ref count);
            foreach (var deviceId in deviceIds)
            {
                var device = new PortableDevice(deviceId);
                Devices.Add(device);
            }
        }

        
    }
}
