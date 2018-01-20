using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator2
{
    class AmericanTravel : Decorator
    {
        public AmericanTravel(Travel travel) 
            : base(travel.Name, travel.Count, travel.Article, travel)
        {
            Name = "Dollar";
            Article = "#2";
        }

        public override double GetCount()
        {
            return _travel.Count / 2;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
