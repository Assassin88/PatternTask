using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_Adapter_PoolObjects.Adapter
{
    class Adapter
    {
        private Bitmap _image;

        public Adapter(Bitmap bitmap)
        {
            Image = bitmap;
        }

        public Bitmap Image { get => _image; set => _image = value; }

        public Bitmap BitmapNegative()
        {
            var bmp = (Bitmap)Image.Clone();
            var width = bmp.Width;
            var height = bmp.Height;

            for (var y = 0; y < height; y++)
            {
                for (var x = 0; x < width; x++)
                {
                    Color p = bmp.GetPixel(x, y);
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    r = 255 - r;
                    g = 255 - g;
                    b = 255 - b;

                    bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }
            return bmp;
        }

        public Bitmap TurnLeft()
        {
            var bitmap = (Bitmap)Image.Clone();
            bitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
            return bitmap;
        }

        public Bitmap TurnRight()
        {
            var bitmap = (Bitmap)Image.Clone();
            bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
            return bitmap;
        }

    }
}
