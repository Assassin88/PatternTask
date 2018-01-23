using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFactoty
{
    class BadStudentDescription : IDescription
    {
        public string Description
        {
            get { return "Bad Student"; }
        }
    }
}
