using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class School : Process
    {
        public int SchoolNumber { get; set; }
        public string SchoolName { get; set; }

        public School(string name, int number)
        {
            SchoolName = name;
            SchoolNumber = number;
        }

        protected override void Enter()
        {
            Console.WriteLine($"Start study in school: {SchoolName}, №{SchoolNumber}");
        }

        protected override void Study()
        {
            Console.WriteLine($"Is studying in school: {SchoolName}, №{SchoolNumber}");
        }

        protected override void PassExam()
        {
            Console.WriteLine($"Is examing in school: {SchoolName}, №{SchoolNumber}");
        }

        protected override void GetAttestat()
        {
            Console.WriteLine($"End study in school: {SchoolName}, №{SchoolNumber}");
        }

        public override string ToString()
        {
            return string.Format($"{SchoolName}, {SchoolNumber}");
        }
    }
}
