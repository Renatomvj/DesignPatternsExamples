using DesignPatterns.Cases.Case1.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Cases.Case1.Factories
{
    public class ShippingFactory : IShippingFactory
    {
        readonly Func<EShippingMethods, IShippingStrategy> factoryFactory;    
        public ShippingFactory(Func<EShippingMethods, IShippingStrategy> factoryFactory)
        {
            this.factoryFactory = factoryFactory;
        }

        public IShippingStrategy Create(EShippingMethods method)
        {
            return factoryFactory(method);
        }
      
    }
}
