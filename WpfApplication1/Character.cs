using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    public class Character
    {
        byte[] _arrayImage;

        public byte[] ArrayImage
        {
            //get => _arrayImage;
            //set => _arrayImage = value;
            get;
            set;
        }

        public Character(string path)
        {
            Image image = Image.FromFile(path);
            _arrayImage = Convert.ImageToByteArray(image);
        }

        
    }
}
