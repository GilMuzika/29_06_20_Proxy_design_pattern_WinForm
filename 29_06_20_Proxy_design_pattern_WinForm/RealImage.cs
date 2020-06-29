using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _29_06_20_Proxy_design_pattern_WinForm
{
    public class RealImage : IImage
    {
        private IImageProvider _imageProvider;

        private string _filename;
        private Bitmap _realImage;
        private int _thisFormWidth;
        private PictureBox _pbxDisplay;

        public RealImage(IImageProvider imageProvider, string filename, int thisFormWidth, PictureBox pbxDisplay)
        {
            _imageProvider = imageProvider;
            _filename = filename;
            _thisFormWidth = thisFormWidth;
            _pbxDisplay = pbxDisplay;
            LoadFromDisk(_filename);
        }

        public void Display()
        {
            ResizingStrategy _resizingStrategy = new ResizingStrategy(_pbxDisplay, _realImage, _thisFormWidth - 10);
            _resizingStrategy.WhatRezize();

            _pbxDisplay = _resizingStrategy.ResizedPictureBox;
            _realImage = _resizingStrategy.ResizedImage;

            _pbxDisplay.Image = _realImage;
        }

        private void LoadFromDisk(string fileName)
        {
            _realImage = _imageProvider.GetImage(fileName);
        }
    }
}
