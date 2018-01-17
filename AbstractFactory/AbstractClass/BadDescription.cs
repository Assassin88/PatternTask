using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatPattens_HomeTask__1
{
    class BadDescription : Description
    {
        public override string GetDescription()
        {
            return "Very bad, you have to work harder";
        }

        public override int GetRating()
        {
            return 3;
        }
    }
}
