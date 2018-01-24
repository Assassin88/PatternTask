using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod.Iterator;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            School school = new School("CentralSchool", 2);
            University university = new University("BGUIR", 8);

            school.EnterProcess();
            Console.WriteLine();
            university.EnterProcess();
            Console.WriteLine();
            Console.WriteLine();

            IteraterRealize iterat = new IteraterRealize();
            iterat.AddItem(new School("A", 1));
            iterat.AddItem(new School("B", 2));
            iterat.AddItem(new University("C",3));
            iterat.AddItem(new University("D", 4));

            foreach (var item in iterat)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            foreach (var item in iterat.GetItemsReversed())
            {
                Console.WriteLine(item);
            }
        }
    }
}
