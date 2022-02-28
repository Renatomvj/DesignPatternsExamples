using DesignPatterns.Cases.Case2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Cases.Case2.Strategies
{
    public class DHLShippingStrategy : IShippingStrategy
    {
        private readonly IWeightMappingService _weightMappingService;

        public DHLShippingStrategy(IWeightMappingService weightMappingService)
        {
            _weightMappingService = weightMappingService;
        }

        public EShippingMethods SupportedShippingMethod => EShippingMethods.DHL;

        public int CalculateShippingCost(Order order)
        {
            // some sort of database call needed to lookup pricing table and weight mappings
            return _weightMappingService.DeterminePrice(order);
        }
    }
}
