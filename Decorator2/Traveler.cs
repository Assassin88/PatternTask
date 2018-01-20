using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator2
{
    class Traveler : Travel
    {
        public Traveler(string name, double count, string article) 
            : base(name, count, article)
        {
        }

        public override double GetCount()
        {
            return Count;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
