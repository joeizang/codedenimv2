using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Drawing.Imaging;
using Microsoft.AspNetCore.Http;

namespace Codedenim.Domain
{
    public class ValidateFileAttribute : RequiredAttribute
    {
        public override bool IsValid(object value)
        {
            if (!(value is IFormFile file))
            {
                return true;
            }

            if (file.Length > 1 * 150 * 150)
            {
                return false;
            }

            try
            {
                using (var img = Image.FromStream(file.OpenReadStream()))
                {
                    return img.RawFormat.Equals(img.RawFormat.Equals(ImageFormat.Png) ? ImageFormat.Png : ImageFormat.Jpeg);
                }
            }
            catch { }
            return false;
        }
    }
}