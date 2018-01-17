using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ObjectPool
{
    class Factor
    {
        public BigInteger RandNumber { get; set; }
        public bool IsUsed { get; set; }
        public Factor()
        {
            Console.WriteLine("\nTrying to open...");
            Thread.Sleep(2000);
            Random rand = new Random();
            RandNumber = rand.Next(100, 10000);
            Console.WriteLine("Create object_Factor!!!\n");
        }

        public BigInteger FactotialNumber()
        {
            BigInteger sum = 1;
            for (long i = 1; i <= RandNumber; i++)
            {
                sum *= i;
            }
            return sum;
        }
    }
}