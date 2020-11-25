using System;
using System.Collections.Generic;
using System.Text;

namespace CodingKatas.CodeKata.Supermarket.Interfaces
{
    public interface IPricingStrategy
    {
        decimal CalculatePrice( SalesLineQuantity salesLineQuantity );
    }
}
