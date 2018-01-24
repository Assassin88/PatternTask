using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class University : Process
    {
        public int UniversityNumber { get; set; }
        public string UniversityName { get; set; }

        public University(string name, int number)
        {
            UniversityName = name;
            UniversityNumber = number;
        }

        protected override void Enter()
        {
            Console.WriteLine($"Start study in University: {UniversityName}, №{UniversityNumber}");
        }

        protected override void Study()
        {
            Console.WriteLine($"Is studying in University: {UniversityName}, №{UniversityNumber}");
        }

        protected override void PassExam()
        {
            Console.WriteLine($"Is examing in University: {UniversityName}, №{UniversityNumber}");
        }

        protected override void GetAttestat()
        {
            Console.WriteLine($"End study in University: {UniversityName}, №{UniversityNumber}");
        }

        public override string ToString()
        {
            return string.Format($"{UniversityName}, {UniversityNumber}");
        }
    }
}
