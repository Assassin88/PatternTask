using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatPattens_HomeTask__1.ConcretClass
{
    class NormalStudent : Studentfactory
    {
        public override Description GetDescriptionStudent()
        {
            return new NormalDescription();
        }
    }
}
