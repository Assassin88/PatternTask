using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFactoty
{
    class GoodStudentRating : IRating
    {
        public int Rating
        {
            get { return 9; }
        }
    }
}
