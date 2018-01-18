using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositXml
{
    class XmlDocument : Root
    {
        private IList<Root> _components =
            new List<Root>();

        public XmlDocument(string name)
            : base(name)
        {}

        public override void Add(Root component)
        {
            _components.Add(component);
        }

        public override void Remove(Root component)
        {
            _components.Remove(component);
        }

        public override void Print()
        {
            Console.WriteLine("Root_element: " + _name);
            Console.WriteLine("Element: ");
            foreach (var item in _components)
            {
                item.Print();
            }
            Console.WriteLine();
        }

    }
}
