using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29_06_20_Proxy_design_pattern_WinForm
{
    public class StrategyOperation2
    {
        public PictureBox ResizedPictureBox { get; private set; }
        public Bitmap ResizedImage { get; private set; }

        private Bitmap _image;
        private int _resizeDesider;
        private PictureBox _pbxDisplay;

        public StrategyOperation2(Bitmap image, int resizeDesider, PictureBox pbxDisplay)
        {
            _image = image;
            _resizeDesider = resizeDesider;
            _pbxDisplay = pbxDisplay;
            FitPictureBoxToImage();
        }

        private void FitPictureBoxToImage()
        {
            this.ResizedImage = _image;

            _pbxDisplay.Width = this.ResizedImage.Width;
            _pbxDisplay.Height = this.ResizedImage.Height;


            this.ResizedPictureBox = _pbxDisplay;
        }


    }
}
