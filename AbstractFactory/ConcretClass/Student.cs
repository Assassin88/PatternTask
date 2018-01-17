using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatPattens_HomeTask__1.ConcretClass
{
class Student
    {
        private Description _description;

        public Student(Studentfactory factory)
        {
            _description = factory.GetDescriptionStudent();
        }

        public int GetRating()
        {
             return _description.GetRating();
        }

        public string GetDescription()
        {
           return _description.GetDescription();
        }
    }
}
