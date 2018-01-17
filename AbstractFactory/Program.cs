using CreatPattens_HomeTask__1.ConcretClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatPattens_HomeTask__1
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Student> list = new List<Student>()
            {
                new Student(new GoodStudent()),
                new Student(new NormalStudent()),
                new Student(new BadStudent()),
                new Student(new OtherStudent())
            };

            foreach (var item in list)
            {
                Console.WriteLine(item.GetRating());
                Console.WriteLine(item.GetDescription());
                Console.WriteLine(new String('*', 30));
            }
            Console.ReadKey();
        }
    }
}
