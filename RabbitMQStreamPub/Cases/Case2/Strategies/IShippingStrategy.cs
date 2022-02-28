using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Cases.Case2.Strategies
{
    public interface IShippingStrategy
    {
        public int CalculateShippingCost(Order order);
        public EShippingMethods SupportedShippingMethod { get; }
    }
}
