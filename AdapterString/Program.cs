using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterString
{
    class Program
    {
        static void Main(string[] args)
        {
            ICount counter = new Counter("Hello World, Hello World");
            counter.Count("elo");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
