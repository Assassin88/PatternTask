using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFactoty
{
    class NormalStudentFactory : IFactory
    {
        public IDescription CreateDescription()
        {
            return new NormalStudentDescription();
        }

        public IRating CreateRating()
        {
            return new NormalStudentRating();
        }
    }
}
