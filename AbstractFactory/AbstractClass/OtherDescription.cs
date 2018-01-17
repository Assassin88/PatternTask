using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatPattens_HomeTask__1
{
    class OtherDescription : Description
    {
        public override string GetDescription()
        {
            return "A special approach is required";
        }

        public override int GetRating()
        {
            return 5;
        }
    }
}
