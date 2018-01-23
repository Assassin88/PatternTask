using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFactoty
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<IFactory> _list = new List<IFactory>();
            IFactory goodStudent = new GoodStudentFactory();
            IFactory nornalStudent = new NormalStudentFactory();
            IFactory badStudent = new BadStudentFactory();
            IFactory japanStudent = new OtherStudentFactory();

            _list.Add(goodStudent);
            _list.Add(nornalStudent);
            _list.Add(badStudent);
            _list.Add(japanStudent);

            foreach (var item in _list)
            {
                var rating = item.CreateRating();
                var description = item.CreateDescription();
                Console.WriteLine($"Description: {description.Description}; Rating: {rating.Rating}");
            }
        }
    }
}
