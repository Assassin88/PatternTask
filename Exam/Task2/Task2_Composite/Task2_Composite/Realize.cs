using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Composite
{
    internal class Realize
    {
        public static void Realization()
        {
            var rootPage = new RootPage();

            var section = new Section("Cat", "World of cat!!!");
            var page = new Page("Cat", "Black cat!!!");
            var page2 = new Page("Cat", "White cat!!!");
            var page3 = new Page("Cat", "Red cat!!!");
            section.AddElement(page);
            section.AddElement(page2);
            section.AddElement(page3);

            var section2 = new Section("Dog", "World of dog!!!");
            page = new Page("Dog", "Good dog!!!");
            page2 = new Page("Dog", "Bad dog!!!");
            page3 = new Page("Dog", "Happy dog!!!");
            section2.AddElement(page);
            section2.AddElement(page2);
            section2.AddElement(page3);

            var section3 = new Section("Raccoon", "World of raccoon!!!");
            page = new Page("Raccoon", "Harmful raccoon!!!");
            page2 = new Page("Raccoon", "Cunning raccoon!!!");
            page3 = new Page("Raccoon", "Thief raccoon!!!");
            section2.AddElement(page);
            section2.AddElement(page2);
            section2.AddElement(page3);

            rootPage.AddElement(section);
            rootPage.AddElement(section2);
            rootPage.AddElement(section3);

            rootPage.Scan();

            Console.ReadKey();
        }
    }
}
