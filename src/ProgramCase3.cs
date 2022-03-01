using Autofac;
using Autofac.Core;
using Autofac.Features.AttributeFilters;
using DesignPatterns.Cases.Case3;
using DesignPatterns.Cases.Case3.Integrations;
using DesignPatterns.Cases.Case3.Proxies;
using DesignPatterns.Cases.Case3.Services;
using DesignPatterns.Cases.Case3.Strategies;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Unity;

namespace DesignPatterns
{
    [ExcludeFromCodeCoverage]
    class ProgramCase3
    {

        static IContainer CompositionRoot()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<WeightMappingService>().As<IWeightMappingService>();
            builder.RegisterType<ZipCodePriceCalculator>().As<IZipCodePriceCalculator>();

            // resgiter strategies using named mappings
            builder.RegisterType<DHLShippingStrategy>().Named<IShippingStrategy>(EShippingMethods.DHL.ToString());
            builder.RegisterType<UPSShippingStrategy>().Named<IShippingStrategy>(EShippingMethods.UPS.ToString());
            builder.RegisterType<SedexxShippingStrategy>().Named<IShippingStrategy>(EShippingMethods.Sedexx.ToString());


            //set proxy parameters 
            var parameters = new List<Parameter>();
            parameters.Add(new ResolvedParameter((p, c) => p.Name == "strategies",
                                                 (p, c) => new List<IShippingStrategy>
                                                 {
                                                     c.ResolveKeyed<IShippingStrategy>(EShippingMethods.DHL.ToString()),
                                                     c.ResolveKeyed<IShippingStrategy>(EShippingMethods.UPS.ToString()),
                                                     c.ResolveKeyed<IShippingStrategy>(EShippingMethods.Sedexx.ToString()),
                                                 }));

            // resgiter proxy            
            builder.RegisterType<ShippingStrategyProxy>().Named<IShippingStrategy>(EShippingMethods.Proxy.ToString()).WithParameters(parameters);

            // register application
            builder.RegisterType<Application>().AsSelf().WithAttributeFiltering();

            return builder.Build();

        }

        static void Main(string[] args)
        {
            CompositionRoot().Resolve<Application>().Run();

            Console.ReadKey();
        }
    }
}