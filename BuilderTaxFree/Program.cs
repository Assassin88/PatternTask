using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderTaxFree
{
    class Program
    {
        //Реализуете паттерн Builder с fluent 
        //интерфейсом для построения объекта 
        //оформления tax free в магазине.

        static void Main(string[] args)
        {
            int _sumTaxFree = 50;
            IList<CountClient> _list = new List<CountClient>();

            var client = new CountClient();
            client.Name("John").Country("Poland").Shop("Maximus").Product("TV").Price(2500);

            var client2 = new CountClient();
            client2.Name("Paul").Country("Poland").Shop("Maximus").Product("Cup").Price(25);

            _list.Add(client);
            _list.Add(client2);

            foreach (var item in _list)
            {
                var sum = item.GetPrice();
                if (sum >= _sumTaxFree)
                {
                    Console.WriteLine("Sum = {0}", sum);
                    sum = (sum - (sum * 0.1));
                    Console.WriteLine("Sum with Tax Free = {0}", sum);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Sum = {0}", sum);
                    Console.WriteLine("No discount");
                    Console.WriteLine();
                }
            }
            
            Console.ReadKey();


        }
    }
}
