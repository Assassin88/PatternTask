using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Proxy : ICount
    {
        private Counter _counter;

        public Proxy(Counter counter)
        {
            _counter = counter;
        }

        public string Count(string str)
        {
            if (str == string.Empty) return string.Empty;
            if (_counter == null)
            {
                _counter = new Counter();
            }
            return _counter.Count(str).ToUpper();
        }
    }
}
