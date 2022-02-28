using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Cases.Case1.Strategies
{
    public class UPSShippingStrategy : IShippingStrategy
    {
        public string SupportedShippingMethod => "UPS";

        public int CalculateShippingCost(Order order)
        {
            if (order.OrderWeight < 5)
                return 10; // flat rate of $10 for packages under 5 lbs
            else
                return 20; // flat rate of $20
        }

    }
}
