using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        //    Для системы, реализующей основные математические операции
        //(сложение, вычитание, умножение, вычисление логарифма,
        //квадратного корня, факториала), напишите Facade, позволяющий
        //клиентскому коду с легкостью пользоваться системой.

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(MathOperation.Sum(2, 3, 5.5));
                Console.WriteLine(MathOperation.Subtraction(50, 10, 15.2, 8.4));
                Console.WriteLine(MathOperation.Multiplication(2, 1, 3.5));
                Console.WriteLine(MathOperation.Log(14, 5));
                Console.WriteLine(MathOperation.Log(14));
                Console.WriteLine(MathOperation.Log10(14));
                Console.WriteLine(MathOperation.Sqrt(81));
                Console.WriteLine(MathOperation.Factorial(4));
                Console.ReadKey();
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
