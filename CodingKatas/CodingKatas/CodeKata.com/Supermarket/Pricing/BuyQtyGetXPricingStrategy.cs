using CodingKatas.CodeKata.Supermarket.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingKatas.CodeKata.Supermarket.Pricing
{
    public class BuyQtyGetXPricingStrategy : IPricingStrategy
    {
        public int QuantityBuy { get; set; }
        public int QuantityGetFree { get; set; }
        public decimal PriceEach { get; set; }

        public decimal CalculatePrice( SalesLineQuantity salesLineQuantity )
        {
            decimal calculatedPrice = 0;
            int extraQuantityRemainder = salesLineQuantity.LineQuantity % QuantityBuy;

            if ( extraQuantityRemainder > 0 )
                calculatedPrice += PriceEach * extraQuantityRemainder;

            int remainingPurchQuantity = salesLineQuantity.LineQuantity - extraQuantityRemainder;
            
            if ( remainingPurchQuantity > 0 )
            {
                int amountOfDeals = remainingPurchQuantity / QuantityBuy;
                int qtyToDiscount = amountOfDeals * QuantityGetFree;

                remainingPurchQuantity -= qtyToDiscount;
                calculatedPrice += remainingPurchQuantity * PriceEach;
            }

            return calculatedPrice;

        }
    }
}
