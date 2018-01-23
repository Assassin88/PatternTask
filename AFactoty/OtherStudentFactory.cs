using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFactoty
{
    class OtherStudentFactory : IFactory
    {
        public IDescription CreateDescription()
        {
            return new OtherStudentDescription();
        }

        public IRating CreateRating()
        {
            return new OtherStudentRating();
        }
    }
}
