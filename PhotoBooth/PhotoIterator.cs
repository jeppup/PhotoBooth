using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoBooth.Entities;
using System.Drawing;
using System.IO;
using WPD;

namespace PhotoBooth
{
    public class PhotoIterator
    {
        private Settings settings { get; set; }
        
        private string[] BaseImagePaths { get; set; }
        private int BaseImageIndex = -1;
        private FileManager fm { get; set; }
        private List<ImageReference> CameraImageReferences {get; set; }

        public PhotoIterator(Settings s)
        {
            settings = s;
            LoadBaseImages();
            CameraImageReferences = new List<ImageReference>();
            fm = new FileManager(settings.ExternalDevice, settings.CameraDirectory);
        }

        private void LoadBaseImages()
        {
            BaseImagePaths = Directory.GetFiles(settings.BaseDirectory);
        }

        public Image GetNextImage()
        {
            LoadNewImages();
            var cameraImage = GetCameraImage();
            if(cameraImage != null)
            {
                return cameraImage;
            }
            else
            {
                return GetBaseImage();
            }
        }

        private void LoadNewImages()
        {
            fm.SynchronizeFiles();
            var freshCameraImagePaths = Directory.GetFiles(settings.CameraDirectory);
            foreach(var imagePath in freshCameraImagePaths)
            {
                if(!CameraImageReferences.Select(ci => ci.Path).Contains(imagePath))
                {
                    CameraImageReferences.Add(new ImageReference(){
                        Path = imagePath,
                        LastShownTime = DateTime.MinValue
                    });
                }
            }
        }

        private Image GetBaseImage()
        {
            BaseImageIndex = BaseImageIndex + 1;
            if(BaseImageIndex >= BaseImagePaths.Length)
            {
                BaseImageIndex = 0;
            }

            return LoadImage(BaseImagePaths[BaseImageIndex]);
        }

        private Image GetCameraImage()
        {
            var orderedReferences = CameraImageReferences.OrderBy(cir => cir.LastShownTime);
            if(orderedReferences.Count() == 0)
            {
                return null;
            }

            var candidateReference = orderedReferences.First();
            if (candidateReference.LastShownTime <= DateTime.Now.AddSeconds(-settings.Cooldown))
            {
                candidateReference.LastShownTime = DateTime.Now;
                return LoadImage(candidateReference.Path);
            }
            else
            {
                return null;
            }
        }

        private Image LoadImage(string path)
        {
            return Bitmap.FromFile(path);
        }
    }
}
