using DesignPatterns.Cases.Case2.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Cases.Case2.Proxies
{
    public class ShippingStrategyProxy : IShippingStrategy
    {
        private readonly IEnumerable<IShippingStrategy> _shippingStrategies;
        public ShippingStrategyProxy(IEnumerable<IShippingStrategy> strategies)
        {
            _shippingStrategies = strategies;
        }
        public EShippingMethods SupportedShippingMethod => EShippingMethods.Proxy;

        public int CalculateShippingCost(Order order) =>
            GetStrategy(order.ShippingMethod).CalculateShippingCost(order);

        private IShippingStrategy GetStrategy(EShippingMethods method)
        {
            var strategy = _shippingStrategies.FirstOrDefault(x => x.SupportedShippingMethod == method);
            if (strategy == null)
                throw new InvalidOperationException($"No supported strategy found for shipping method. {method}");

            return strategy;
        }        
    }
}
