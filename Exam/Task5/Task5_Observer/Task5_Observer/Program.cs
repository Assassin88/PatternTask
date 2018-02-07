using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var collectionInteger = new CollectionInteger();
            var listener = new Listener();
            Random random = new Random();

            var unsubscriber = collectionInteger.Subscribe(listener);

            for (int i = 0; i < 8; i++)
            {
                collectionInteger.AddElement(random.Next(10, 100));
            }

            Console.WriteLine("\nAssorted collection!!!");
            foreach (var item in collectionInteger)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            unsubscriber.Dispose();

            for (int i = 0; i < 10; i++)
            {
                collectionInteger.AddElement(random.Next(10, 100));
            }

            Console.WriteLine("\nNot sorted collection!!!");
            foreach (var item in collectionInteger)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
