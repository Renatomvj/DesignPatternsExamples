using DesignPatterns.Cases.Case1;
using DesignPatterns.Cases.Case1.Factories;
using DesignPatterns.Cases.Case1.Integrations;
using DesignPatterns.Cases.Case1.Services;
using DesignPatterns.Cases.Case1.Strategies;
using DesignPatterns.Command.Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Unity;

namespace DesignPatterns
{
    public static class ContainerCase1
    {
        public static IUnityContainer Configure()
        {
            // DI using unity container
            var container = new UnityContainer();

            // register services
            container.RegisterType<IWeightMappingService, WeightMappingService>();
            container.RegisterType<IZipCodePriceCalculator, ZipCodePriceCalculator>();
            
            // resgiter strategies using named mappings
            container.RegisterType<IShippingStrategy, DHLShippingStrategy>(EShippingMethods.DHL.ToString());
            container.RegisterType<IShippingStrategy, UPSShippingStrategy>(EShippingMethods.UPS.ToString());
            container.RegisterType<IShippingStrategy, SedexxShippingStrategy>(EShippingMethods.Sedexx.ToString());

            // create the strategy
            Func<EShippingMethods, IShippingStrategy> factoryFactory = (shippingMethod) => container.Resolve<IShippingStrategy>(shippingMethod.ToString());

            //registry factory
            var factory = new ShippingFactory(factoryFactory);
            container.RegisterInstance<IShippingFactory>(factory);

            return container;

        }
    }
}
