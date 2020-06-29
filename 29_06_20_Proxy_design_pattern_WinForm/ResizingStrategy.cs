using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29_06_20_Proxy_design_pattern_WinForm
{
    public class ResizingStrategy
    {
        public PictureBox ResizedPictureBox { get; private set; }
        public Bitmap ResizedImage { get; private set; }

        private PictureBox _pbxDisplay;
        private Bitmap _image;
        private int _resizeDesider;

        public ResizingStrategy(PictureBox pbxDisplay, Bitmap image, int resizeDesider)
        {
            _pbxDisplay = pbxDisplay;
            _image = image;
            _resizeDesider = resizeDesider;
        }

        public void WhatRezize()
        {
            if (_image.Width > _resizeDesider)
            {
                StrategyOperation1 so1 = new StrategyOperation1(_image, _resizeDesider);
                this.ResizedImage = so1.ResizedImage;
                StrategyOperation2 so2 = new StrategyOperation2(ResizedImage, _resizeDesider, _pbxDisplay);                
                this.ResizedPictureBox = so2.ResizedPictureBox;


            }
            else 
            {
                StrategyOperation2 so2 = new StrategyOperation2(_image, _resizeDesider, _pbxDisplay);
                this.ResizedImage = so2.ResizedImage;
                this.ResizedPictureBox = so2.ResizedPictureBox;
            }
        }


    }
}
