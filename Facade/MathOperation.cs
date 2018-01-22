using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class MathOperation
    {

        /// <summary>
        /// Returns the Sum parameters of array.
        /// </summary>
        /// <param name="sum">Source number</param>
        /// <param name="array">parameters for count sum</param>
        /// <returns></returns>
        public static double Sum(double sum, params double[] array)
        {
            foreach (var item in array)
            {
                sum += item;
            }
            return sum;
        }

        /// <summary>
        /// Returns the difference parameters of array.
        /// </summary>
        /// <param name="sum">Source number</param>
        /// <param name="arrary">Numbers for subtraction</param>
        /// <returns></returns>
        public static double Subtraction(double sum, params double[] arrary)
        {
            foreach (var item in arrary)
            {
                sum -= item;
            }
            return sum;
        }

        /// <summary>
        /// Returns the number after multiplication.
        /// </summary>
        /// <param name="sum">Source number</param>
        /// <param name="array">Numbers for multiplication</param>
        /// <returns></returns>
        public static double Multiplication(double sum, params double[] array)
        {
            if (sum != 0)
            {
                foreach (var item in array)
                {
                    if (item == 0) throw new ArithmeticException("Invalid value in parameters...");
                    sum *= item;
                }
                return sum;
            }
            return 0;
        }

        /// <summary>
        /// Returns the logarithm of a specified number in a specified base.
        /// </summary>
        /// <param name="x">Source number</param>
        /// <param name="y">Degree</param>
        /// <returns></returns>
        public static double Log(double x, double y)
        {
            if (x == 0 || y == 0)
            {
                throw new ArithmeticException("Invalid value in parameters...");
            }
            return Math.Log(x, y);
        }

        /// <summary>
        /// Returns the natural logarithm of a specified number.
        /// </summary>
        /// <param name="x">Source number</param>
        /// <returns></returns>
        public static double Log(double x)
        {
            if (x == 0)
            {
                throw new ArithmeticException("Invalid value in parameters...");
            }
            return Math.Log(x);
        }

        /// <summary>
        /// Returns the natural logarithm of a specified number.
        /// </summary>
        /// <param name="x">Source number</param>
        /// <returns></returns>
        public static double Log10(double x)
        {
            if (x == 0)
            {
                throw new ArithmeticException("Invalid value in parameters...");
            }
            return Math.Log10(x);
        }

        /// <summary>
        /// Returns the square root of a specified number.
        /// </summary>
        /// <param name="x">Source number</param>
        /// <returns></returns>
        public static double Sqrt(double x)
        {
            if (x == 0)
            {
                throw new ArithmeticException("Invalid value in parameters...");
            }
            return Math.Sqrt(x);
        }

        /// <summary>
        /// Returns the factorial of a specified number.
        /// </summary>
        /// <param name="x">Source number</param>
        /// <returns></returns>
        public static int Factorial(int x)
        {
            if (x < 0)
            {
                throw new ArithmeticException("Invalid value in parameters...");
            }
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }
    }
}
