using CodingKatas.CodeKata.Supermarket.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingKatas.CodeKata.Supermarket.Pricing
{
    public class QuantityforPricePricingStrategy : IPricingStrategy
    {
        public int QuantityStep { get; set; }
        public int QuantityMinimum { get; set; }
        public decimal PriceStep { get; set; }
        public decimal PriceEach { get; set; }
        public decimal CalculatePrice( SalesLineQuantity salesLineQuantity )
        {
            decimal totalPrice = 0;
            int amountOfEach = salesLineQuantity.LineQuantity % QuantityStep;
            if ( amountOfEach > 0 )
            {
                totalPrice += PriceEach * amountOfEach;
            }

            int evenStep = salesLineQuantity.LineQuantity - amountOfEach;
            if ( evenStep > 0 && QuantityStep > 0 )
            {
                int dealQuantity = evenStep / QuantityStep;
                totalPrice += PriceStep * evenStep;
            }            
            return totalPrice;
        }
    }
}
