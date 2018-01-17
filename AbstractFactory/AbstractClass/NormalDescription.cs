using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatPattens_HomeTask__1
{
    class NormalDescription : Description
    {
        public override string GetDescription()
        {
            return "Not bad performance, but it is possible and better";
        }

        public override int GetRating()
        {
            return 7;
        }
    }
}
