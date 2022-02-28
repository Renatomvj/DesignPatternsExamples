using DesignPatterns.Cases.Case2;
using DesignPatterns.Cases.Case2.Integrations;
using DesignPatterns.Cases.Case2.Proxies;
using DesignPatterns.Cases.Case2.Services;
using DesignPatterns.Cases.Case2.Strategies;
using Unity;

namespace DesignPatterns
{

    public static class ContainerCase2
    {
        public static IUnityContainer Configure()
        {
            // DI using unity container
            var container = new UnityContainer();

            container.RegisterType<IWeightMappingService, WeightMappingService>();
            container.RegisterType<IZipCodePriceCalculator, ZipCodePriceCalculator>();

            // resgiter strategies using named mappings
            container.RegisterType<IShippingStrategy, DHLShippingStrategy>(EShippingMethods.DHL.ToString());
            container.RegisterType<IShippingStrategy, UPSShippingStrategy>(EShippingMethods.UPS.ToString());
            container.RegisterType<IShippingStrategy, SedexxShippingStrategy>(EShippingMethods.Sedexx.ToString());

            // resgiter proxy
            container.RegisterType<IShippingStrategy, ShippingStrategyProxy>(EShippingMethods.Proxy.ToString());
            

            return container;

        }
    }
}
