using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator2
{
    abstract class Travel
    {
        public string Name { get; set; }
        public double Count { get; set; }
        public string Article { get; set; }

        public Travel(string name, double count, string article)
        {
            Name = name;
            Count = count;
            Article = article;
        }

        public abstract double GetCount();

        public override string ToString()
        {
            return string.Format($"{Name} {GetCount()} {Article}");
        }
    }
}
