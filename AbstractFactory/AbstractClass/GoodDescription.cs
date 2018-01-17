using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatPattens_HomeTask__1
{
    class GoodDescription : Description
    {
        public override string GetDescription()
        {
            return "Great work, keep it up";
        }

        public override int GetRating()
        {
            return 9;
        }
    }
}
