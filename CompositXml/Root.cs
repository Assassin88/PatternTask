using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositXml
{
    abstract class Root
    {
        protected string _name;

        public Root(string name)
        {
            _name = name;
        }

        public virtual void Add(Root component) { }

        public virtual void Remove(Root component) { }

        public virtual void Print()
        {
            Console.WriteLine(_name);
        }
    }
}
