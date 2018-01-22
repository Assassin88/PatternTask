using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator2
{
    class EuropeTravel : Decorator
    {
        public EuropeTravel(Travel travel)
            : base(travel.Name, travel.Count, travel.Article, travel)
        {
            Name = "Euro";
            Article = "#3";
        }

        public override double GetCount()
        {
            return _travel.Count / 2.5;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
