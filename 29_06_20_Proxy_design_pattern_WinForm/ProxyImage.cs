using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace _29_06_20_Proxy_design_pattern_WinForm
{
    public class ProxyImage : IImage
    {
        private IImageProvider _imageProvider;
        private RealImage _realImage;

        private string _filename;
        int _thisFormWidth;
        PictureBox _pbxDisplay;

        public ProxyImage(IImageProvider imageProvider, string filename, int thisFormWidth, PictureBox pbxDisplay)
        {
            _imageProvider = imageProvider;
            _filename = filename;
            _thisFormWidth = thisFormWidth;
            _pbxDisplay = pbxDisplay;
        }

        public void Display()
        {
            if(_realImage == null)
            {
                _realImage = new RealImage(_imageProvider, _filename, _thisFormWidth, _pbxDisplay);
            }
            _realImage.Display();
        }
    }
}
