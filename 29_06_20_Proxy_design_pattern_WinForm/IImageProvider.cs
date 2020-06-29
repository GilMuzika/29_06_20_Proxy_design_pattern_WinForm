using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_06_20_Proxy_design_pattern_WinForm
{
    public interface IImageProvider
    {
        Bitmap GetImage(string imagePath);
        Bitmap ResizeImageProportionally(Image image, int newWidth);
        Bitmap ResizeImage(Image image, int width, int height);
        System.Drawing.Imaging.ImageFormat GetImageFormat(System.Drawing.Image img, out string extension);


    }
}
