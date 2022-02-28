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

        public IShippingStrategy GetStrategy(EShippingMethods method)
        {

            var shipping = Instantiate<IShippingStrategy>(method + "ShippingStrategy");

            return shipping;


            //switch (method)
            //{
            //    case "DHL": return container.Resolve<IShippingStrategy>("DHL");
            //    case "UPS": return container.Resolve<IShippingStrategy>("UPS");
            //    case "Sedexx": return container.Resolve<IShippingStrategy>("Sedexx");
            //    default: throw new InvalidOperationException($"No supported strategy found for shipping method. {method}");
            //}
        }

        private static T Instantiate<T>(string className)
        {
            Type typeImplemented = typeof(T);
            Type selectedType = Assembly.GetExecutingAssembly() 
                    .GetTypes()
                    .FirstOrDefault(t => typeImplemented.IsAssignableFrom(t) && t.Name == className);

            if (selectedType == null)
                throw new InvalidOperationException($"No supported strategy found for shipping method. {className}");

            return (T)Activator.CreateInstance(selectedType);
        }

      
    }
}
