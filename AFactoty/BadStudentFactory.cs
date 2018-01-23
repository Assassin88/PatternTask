using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFactoty
{
    class BadStudentFactory : IFactory
    {
        public IDescription CreateDescription()
        {
            return new BadStudentDescription();
        }

        public IRating CreateRating()
        {
            return new BadStudentRating();
        }
    }
}
