using Core.Utilities.Helpers.GuidHelperr;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Helpers.FileHelper
{
    public class ImageHelperManager : IImagesHelper
    {
        public void Delete(string imagePath)
        {
            if (File.Exists(imagePath))
            {
                File.Delete(imagePath);
            }
        }

        public string Update(IFormFile image, string imagePath, string root)
        {
            if (File.Exists(imagePath))
            {
                File.Delete(imagePath);
                return Upload(image, root);
            }
            return Upload(image, root);

        }

        public string Upload(IFormFile image, string root)
        {
            if (image.Length > 0)
            {
                if (!Directory.Exists(root))
                {
                    Directory.CreateDirectory(root);
                }
                string extension = Path.GetExtension(image.FileName);
                string guid = GuidHelper.CreateGuid();
                string imagePath = guid + extension;

                using (FileStream fileStream = File.Create(root + imagePath))
                {
                    image.CopyTo(fileStream);
                    fileStream.Flush();
                    return imagePath;
                }
            }
            return null;
        }
    }
}
