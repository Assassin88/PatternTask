using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterString
{
    class Counter : ICount
    {
        private readonly string _text;
        private int _count;

        public Counter(string text)
        {
            _text = text;
        }

        public void Count(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                _count += _text.Count(el => el.Equals(str[i]));
                Console.WriteLine($"{str[i]} = {_count}");
                _count = 0;
            }
        }
    }
}
