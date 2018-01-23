using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderTaxFree
{
    class CountClient : ICountProduct
    {
        public string CountryName { get; set; }
        public string ShopName { get; set; }
        public string ClientName { get; set; }
        public string ProductName { get; set; }
        public double CountPrice { get; set; }

        public ICountProduct Country(string text)
        {
            CountryName = text;
            return this;
        }

        public double GetPrice()
        {
            return CountPrice;
        }

        public ICountProduct Name(string text)
        {
            ClientName = text;
            return this;
        }

        public ICountProduct Price(double price)
        {
            CountPrice += price;
            return this;
        }

        public ICountProduct Product(string text)
        {
            ProductName = text;
            return this;
        }

        public ICountProduct Shop(string text)
        {
            ShopName = text;
            return this;
        }
    }
}