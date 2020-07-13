using System;
using System.Collections.Generic;
using System.Text;

namespace ExcPolimorfismoProduct.Entities
{
    class UsedProduct : Product
    {
        public DateTime Manufacture { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufacture) : base (name, price)
        {
            Manufacture = manufacture;
        }

        public sealed override string PriceTag()
        {
            return base.PriceTag() + "(Manufacture date: "+ Manufacture.ToShortDateString() + ")";
        }
    }
}
