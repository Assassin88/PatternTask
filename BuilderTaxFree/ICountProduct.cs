using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderTaxFree
{
    interface ICountProduct
    {
        ICountProduct Prod_One(int price);
        ICountProduct Prod_Two(int price);
        ICountProduct Prod_Three(int price);
        ICountProduct Prod_Four(int price);
        ICountProduct Prod_Five(int price);
        double GetPrice();
    }
}
