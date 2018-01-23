using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton_Log
{
    class Program
    {
        //Реализовать сервис логирования сообщений в текстовый файл.
        //Исключить возможность создания нескольких объектов сервиса.
        //Путь к файлу настраивается пользователем.
        static void Main(string[] args)
        {
            Console.WriteLine("Car.GetInstance();");
            var car  = Loger.GetInstance();
            Thread.Sleep(2000);

            var car2 = Loger.GetInstance();

            Loger.ReleaseSource();
            Console.WriteLine("Car.ReleaseSource();");

            car2 = Loger.GetInstance();
            Console.WriteLine("Car.GetInstance();");
            Thread.Sleep(2000);

            Loger.ReleaseSource();
            Console.WriteLine("Car.ReleaseSource();");

            Console.ReadKey();
        }
    }
}
