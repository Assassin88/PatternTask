using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderTaxFree
{
    interface ICountProduct
    {
        string CountryName { get; set; }
        string ShopName { get; set; }
        string ClientName { get; set; }
        string ProductName { get; set; }
        double CountPrice { get; set; }

        ICountProduct Country(string text);
        ICountProduct Shop(string text);
        ICountProduct Name(string text);
        ICountProduct Product(string text);
        ICountProduct Price(double price);
        double GetPrice();
    }
}
