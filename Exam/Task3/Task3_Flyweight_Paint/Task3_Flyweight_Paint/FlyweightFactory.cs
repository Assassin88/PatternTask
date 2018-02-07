using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3_Flyweight_Paint
{
    class FlyweightFactory
    {
        private static readonly Dictionary<string, Color> _dictionary = new Dictionary<string, Color>();

        static FlyweightFactory()
        {
            _dictionary.Add("Black", Color.Black);
            _dictionary.Add("Red", Color.Red);
            _dictionary.Add("Yellow", Color.Yellow);
            _dictionary.Add("Blue", Color.Blue);
            _dictionary.Add("Green", Color.Green);
            _dictionary.Add("Gray", Color.Gray);
            _dictionary.Add("Brown", Color.Brown);
            _dictionary.Add("Aqua", Color.Aqua);
            _dictionary.Add("Coral", Color.Coral);
            _dictionary.Add("Gold", Color.Gold);
            _dictionary.Add("Orange", Color.Orange);
            _dictionary.Add("Pink", Color.Pink);
            _dictionary.Add("White", Color.White);
        }

        public static Color GetColor(string color)
        {
            if (_dictionary.ContainsKey(color))
            {
                return _dictionary[color];
            }
            MessageBox.Show("Default color!!!");
            return Color.Black;
        }

    }
}
