using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_Adapter_PoolObjects.Adapter
{
    class Mediator
    {
        private readonly Adapter _adapter;

        public Mediator(Bitmap bitmap)
        {
            _adapter = new Adapter(bitmap);
        }

        public Bitmap GetPicture(PictureAdapter picture)
        {
            switch (picture)
            {
                case PictureAdapter.Original:
                    {
                        return _adapter.Image;
                    }
                case PictureAdapter.Negative:
                    {
                        return _adapter.BitmapNegative();
                    }
                case PictureAdapter.TurnLeft:
                    {
                        return _adapter.TurnLeft();
                    }
                case PictureAdapter.TurnRight:
                    {
                        return _adapter.TurnRight();
                    }
                default:
                    return _adapter.Image;
            }
        }
    }

    enum PictureAdapter
    {
        Original,
        Negative,
        TurnLeft,
        TurnRight
    }
}
