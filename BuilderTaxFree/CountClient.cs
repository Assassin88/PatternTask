using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderTaxFree
{
    class CountClient : ICountProduct
    {
        private double _price;
        
        public ICountProduct Prod_Five(int price)
        {
            _price += price;
            return this;
        }

        public ICountProduct Prod_Four(int price)
        {
            _price += price;
            return this;
        }

        public ICountProduct Prod_One(int price)
        {
            _price += price;
            return this;
        }

        public ICountProduct Prod_Three(int price)
        {
            _price += price;
            return this;
        }

        public ICountProduct Prod_Two(int price)
        {
            _price += price;
            return this;
        }

        public double GetPrice()
        {
            return _price;
        }
    }
}