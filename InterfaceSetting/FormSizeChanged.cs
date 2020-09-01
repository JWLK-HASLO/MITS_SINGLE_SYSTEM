using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MITS_SINGLE_SYSTEM
{
    public partial class MITS_SYSTEM
    {
        Bitmap bitmapImaging;
        Bitmap bitmapRenew;
        int width_ImagingBox = 0;
        int height_ImagingBox = 0;

        private void FormChangedInit()
        {
            width_ImagingBox = ImagingBox.Width;
            height_ImagingBox = ImagingBox.Height;
            bitmapImaging = new Bitmap(10, 1331);
            bitmapRenew = bitmapImaging as Bitmap;
            ImagingBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        /* 
         * 
         * OPTION Tab Button Control 
         *
         */

        private void ImagingBox_SizeChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Graphic Imaging Width : {0} / Height : {1} / Ratio {2}", ImagingBox.Width, ImagingBox.Height, Math.Sqrt(Math.Pow(ImagingBox.Width, 2) + Math.Pow(ImagingBox.Height, 2)));
            width_ImagingBox = ImagingBox.Width;
            height_ImagingBox = ImagingBox.Height;
            //bitmapImaging = new Bitmap(width_ImagingBox, height_ImagingBox);
            //bitmapRenew = bitmapImaging as Bitmap;
        }


        /* 
         * 
         * OPTION Tab Button Function 
         * 
         */

    }
}
