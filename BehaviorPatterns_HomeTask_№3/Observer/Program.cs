using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var observer = new Observer("A");
            observer.AddObserver(new Messenger());
            var count = 0;
            var timer = new Timer(1000);
            
            timer.Elapsed += (s,e) => 
            {
                observer.Count = count += 5;
                Console.WriteLine(observer.Count);
            };
            timer.Start();

            Console.ReadKey();
        }
    }
}
