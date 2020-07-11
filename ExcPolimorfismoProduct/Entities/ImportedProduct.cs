﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExcPolimorfismoProduct.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base  (name, price)
        {
            CustomsFee = customsFee;
        }

        public sealed override string PriceTag()
        {
            return base.PriceTag() + " (Customs fee: $ "+CustomsFee.ToString("F2",CultureInfo.InvariantCulture)+")" ;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }


    }
}
