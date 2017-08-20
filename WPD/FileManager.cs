using PortableDeviceApiLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WPD
{
    public class FileManager
    {
        PortableDevice Device { get; set; }
        string FolderPath { get; set; }
        public FileManager(PortableDevice device, string folderPath)
        {
            Device = device;
            FolderPath = folderPath;
        }

        public void SynchronizeFiles()
        {
            Device.Connect();
            var name = Device.FriendlyName;
            var folder = Device.GetContents();
            var deviceFiles = GetAllFileReferences(folder);
            var computerFiles = Directory.GetFiles(FolderPath)
                .Select(Path.GetFileName);

            foreach(var deviceFile in deviceFiles)
            {
                if(!computerFiles.Contains(deviceFile.Id + ".jpg"))
                {
                    Device.DownloadFile(deviceFile, FolderPath);
                }
            }

            Device.Disconnect();
        }

        public List<PortableDeviceFile> GetAllFileReferences(PortableDeviceFolder folder)
        {
            var files = new List<PortableDeviceFile>();
            foreach(var item in folder.Files)
            {
                if(item is PortableDeviceFile)
                {
                    files.Add((PortableDeviceFile)item);
                }
                else if(item is PortableDeviceFolder)
                {
                    files.AddRange(GetAllFileReferences((PortableDeviceFolder)item));
                }
            }

            return files;
        }

        public void DisplayObject(PortableDeviceObject portableDeviceObject)
        {
            Console.WriteLine(portableDeviceObject.Name);
            if (portableDeviceObject is PortableDeviceFolder)
            {
                DisplayFolderContents((PortableDeviceFolder)portableDeviceObject);
            }
        }

        static int fileIndex = 1;
        public void DisplayFolderContents(PortableDeviceFolder folder)
        {
            foreach (var item in folder.Files)
            {
                Console.WriteLine(item.Id);
                if (item is PortableDeviceFolder)
                {
                    DisplayFolderContents((PortableDeviceFolder)item);
                }
            }
        }
    }
}
