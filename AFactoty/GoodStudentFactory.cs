using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFactoty
{
    class GoodStudentFactory : IFactory
    {
        public IDescription CreateDescription()
        {
            return new GoodStudentDescription();
        }

        public IRating CreateRating()
        {
            return new GoodStudentRating();
        }
    }
}
