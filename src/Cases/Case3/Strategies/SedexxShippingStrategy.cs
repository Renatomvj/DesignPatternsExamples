using DesignPatterns.Cases.Case3.Integrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Cases.Case3.Strategies
{
    public class SedexxShippingStrategy : IShippingStrategy
    {
        private readonly IZipCodePriceCalculator _zipCodePriceCalculator;

        public SedexxShippingStrategy(IZipCodePriceCalculator zipCodePriceCalculator)
        {
            _zipCodePriceCalculator = zipCodePriceCalculator;
        }

        public EShippingMethods SupportedShippingMethod => EShippingMethods.Sedexx;

        public int CalculateShippingCost(Order order)
        {            
            return _zipCodePriceCalculator.CalculateShippingCost(order.OrderZipCode);
        }
    }
}
