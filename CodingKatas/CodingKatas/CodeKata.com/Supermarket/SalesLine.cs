using System;
using System.Collections.Generic;
using System.Text;

namespace CodingKatas.CodeKata.Supermarket
{
    public class SalesLine
    {
        public SalesLineQuantity SalesLineQuantity { get; set; }
        public decimal TotalPrice { get => CalculateTotalPrice(); }
        public Item Item { get; set; }

        public decimal CalculateTotalPrice()
        {
            decimal lowestPrice = decimal.MaxValue;
            if ( Item != null && Item.PricingStrategies != null )
            {
                foreach ( var itemStrategy in Item.PricingStrategies )
                {
                    decimal calculatedPrice = itemStrategy.CalculatePrice(SalesLineQuantity);
                    if ( calculatedPrice < lowestPrice )
                        lowestPrice = calculatedPrice;
                }
            }
            else
                throw new ArgumentNullException("Item and Item.PricingStrategies cannot be null.");
            
            return lowestPrice;
        }
    }
}
