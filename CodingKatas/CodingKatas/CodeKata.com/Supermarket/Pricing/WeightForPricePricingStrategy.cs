using CodingKatas.CodeKata.Supermarket.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingKatas.CodeKata.Supermarket.Pricing
{
    public class WeightForPricePricingStrategy : IPricingStrategy
    {
        public float QuantityPer { get; set; }
        public decimal Price { get; set; }
        public decimal CalculatePrice( SalesLineQuantity salesLineQuantity )
        {            
            float ratio = salesLineQuantity.Weight / QuantityPer;
            return (decimal)ratio * Price;            
        }
    }
}
