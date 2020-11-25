using CodingKatas.CodeKata.Supermarket.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingKatas.CodeKata.Supermarket
{
    public class Item
    {
        public string SKU { get; set; }
        public string Name { get; set; }
        public List<IPricingStrategy> PricingStrategies { get; set; }
    }
}
