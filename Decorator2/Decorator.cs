using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator2
{
    abstract class Decorator : Travel
    {
        protected Travel _travel;

        public Decorator(string name, double count, string article, Travel travel) 
            : base(name, count, article)
        {
            _travel = travel;
        }
    }
}
