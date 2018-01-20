using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();
            counter.Text = "Hello World, Hello World";
            Console.WriteLine(counter.Count("elo"));
            Console.WriteLine();
            ICount proxy = new Proxy(counter);
            Console.WriteLine(proxy.Count("elo"));
            Console.ReadKey();
        }
    }
}
