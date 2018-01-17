using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPool
{
    class Program
    {
        //Пусть существует класс, в конструкторе которого 
        //генерируется случайное число от 100 до 10000 и 
        //высчитывается его факториал.Создайте пул объектов 
        //такого класса.Стратегия переполнения - ожидание 
        //освобождения. Минимальное и максимальное количество 
        //элементов пула настраивается пользователем.
        static void Main(string[] args)
        {
            //Factor f = new Factor();
            //Console.WriteLine(f.RandNumber);
            //Console.WriteLine(f.FactotialNumber());
            //Console.ReadLine();

            Console.WriteLine("Initialize pool!!!");
            var pool = new ConnectionPool(6);

            Console.WriteLine("Get 1st connect - fast");
            var connection = pool.GetFactor();

            Console.WriteLine("Get 2nd connect - fast");
            var connection2 = pool.GetFactor();

            Console.WriteLine("Get 3rd connect - slow");
            var connection3 = pool.GetFactor();

            pool.ReleaseFactor(connection2);
            pool.ReleaseFactor(connection3);

            Console.WriteLine("Get 4th connect - fast");
            var connection4 = pool.GetFactor();

            Console.WriteLine("Get 5th connect - fast");
            var connection5 = pool.GetFactor();

            Console.WriteLine("Get 6th connect - slow");
            var connection6 = pool.GetFactor();

            Console.ReadKey();
        }
    }
}
