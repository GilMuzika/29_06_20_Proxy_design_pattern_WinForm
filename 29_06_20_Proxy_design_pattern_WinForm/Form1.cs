using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29_06_20_Proxy_design_pattern_WinForm
{
    public partial class Form1 : Form
    {
        private int _thisFormWidth;
        private IImageProvider _imageProvider;

        private string _imageFilePath;

        public Form1()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            this.Text = "Proxy and Strategy design patterns";
            pbxDisplayImage.Location = new Point(5,5);            

            _thisFormWidth = this.ClientRectangle.Width;
            _imageProvider = new ImageProvider();
            
            btnImage.Click += (object sender, EventArgs e) => 
            {
                _imageFilePath = PickUpImageFileName(_imageFilePath);

                IImage image = new ProxyImage(_imageProvider, _imageFilePath, _thisFormWidth, pbxDisplayImage);
                image.Display();

            };

            
            
        }

        private string PickUpImageFileName(string fileName)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.FileName = fileName;
            dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF; *.Png)|*.BMP;*.JPG;*.GIF; *.Png";
            dialog.ShowDialog();
            return dialog.FileName;
        }
    }
}
