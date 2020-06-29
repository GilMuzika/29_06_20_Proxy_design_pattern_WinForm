using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29_06_20_Proxy_design_pattern_WinForm
{
    public class StrategyOperation1
    {
        public Bitmap ResizedImage { get; private set; }

        private Bitmap _image;
        private int _resizeDesider;

        public StrategyOperation1(Bitmap image, int resizeDesider)
        {
            _image = image;
            _resizeDesider = resizeDesider;
            ResizeImage();
        }

        private void ResizeImage()
        {
            this.ResizedImage = new ImageProvider().ResizeImageProportionally(_image, _resizeDesider);
        }

    }
}
