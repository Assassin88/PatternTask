using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFactoty
{
    interface IFactory
    {
        IRating CreateRating();
        IDescription CreateDescription();
    }
}
