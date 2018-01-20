using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Travel travel = new Traveler("Bel.Rub", 10000D, "#1");
            Console.WriteLine(travel);

            travel = new AmericanTravel(travel);
            Console.WriteLine(travel);

            travel = new EuropeTravel(travel);
            Console.WriteLine(travel);

            Console.ReadKey();
        }
    }
}
