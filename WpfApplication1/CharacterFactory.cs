using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    public class CharacterFactory
    {
        Dictionary<char, Character> _imageLetter = new Dictionary<char, Character>();

        public CharacterFactory()
        {
            _imageLetter.Add('A', new Character("F:\\Patterns\\Day4\\StructuralPatterns\\WpfApplication1\\Images\\A.jpg"));
            _imageLetter.Add('B', new Character("F:\\Patterns\\Day4\\StructuralPatterns\\WpfApplication1\\Images\\B.jpg"));
            _imageLetter.Add('C', new Character("F:\\Patterns\\Day4\\StructuralPatterns\\WpfApplication1\\Images\\C.jpg"));
        }

        public byte[] GetImage(char key)
        {
            if (_imageLetter.ContainsKey(key))
                return _imageLetter[key].ArrayImage;
            else
                return null;
        }
    }
}
