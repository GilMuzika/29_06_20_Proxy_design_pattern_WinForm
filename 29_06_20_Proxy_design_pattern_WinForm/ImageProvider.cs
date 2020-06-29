using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _29_06_20_Proxy_design_pattern_WinForm
{
    public class ImageProvider : IImageProvider
    {

        public Bitmap GetImage(string imagePath)
        {
            return new Bitmap(imagePath);
        }

        public Bitmap ResizeImageProportionally(Image image, int newWidth)
        {
            float originalWidth = image.Width;
            float originalHeight = image.Height;

            int newHeight = Convert.ToInt32(newWidth / (originalWidth / originalHeight));
            return ResizeImage(image, newWidth, newHeight);
        }
            
        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <param name="width">The width to resize to.</param>
        /// <param name="height">The height to resize to.</param>
        /// <returns>The resized image.</returns>
        public Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }


        public System.Drawing.Imaging.ImageFormat GetImageFormat(System.Drawing.Image img, out string extension)
        {
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Jpeg))
            {
                extension = "jpg";
                return System.Drawing.Imaging.ImageFormat.Jpeg;
            }
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Bmp))
            {
                extension = "bmp";
                return System.Drawing.Imaging.ImageFormat.Bmp;
            }
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Png))
            {
                extension = "png";
                return System.Drawing.Imaging.ImageFormat.Png;
            }
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Emf))
            {
                extension = "emf";
                return System.Drawing.Imaging.ImageFormat.Emf;
            }
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Exif))
            {
                extension = "exif";
                return System.Drawing.Imaging.ImageFormat.Exif;
            }
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Gif))
            {
                extension = "gif";
                return System.Drawing.Imaging.ImageFormat.Gif;
            }
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Icon))
            {
                extension = "ico";
                return System.Drawing.Imaging.ImageFormat.Icon;
            }
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.MemoryBmp))
            {
                extension = "memoryBmp";
                return System.Drawing.Imaging.ImageFormat.MemoryBmp;
            }
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Tiff))
            {
                extension = "tif";
                return System.Drawing.Imaging.ImageFormat.Tiff;
            }
            else
            {
                extension = "wmf";
                return System.Drawing.Imaging.ImageFormat.Wmf;
            }
        }
    }
}
