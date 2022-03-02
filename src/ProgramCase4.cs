using Autofac;
using Autofac.Core;
using Autofac.Features.AttributeFilters;
using DesignPatterns.Cases.Case4;
using DesignPatterns.Cases.Case4.Integrations;
using DesignPatterns.Cases.Case4.Proxies;
using DesignPatterns.Cases.Case4.Services;
using DesignPatterns.Cases.Case4.Strategies;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Unity;

namespace DesignPatterns
{
    [ExcludeFromCodeCoverage]
    class ProgramCase4
    {

        static IContainer CompositionRoot()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<WeightMappingService>().As<IWeightMappingService>();
            builder.RegisterType<ZipCodePriceCalculator>().As<IZipCodePriceCalculator>();

            //// resgiter strategies using named mappings
            //builder.RegisterType<DHLShippingStrategy>().Named<IShippingStrategy>(EShippingType.DHL.ToString());
            //builder.RegisterType<UPSShippingStrategy>().Named<IShippingStrategy>(EShippingType.UPS.ToString());
            //builder.RegisterType<SedexxShippingStrategy>().Named<IShippingStrategy>(EShippingType.Sedexx.ToString());


            ////set proxy parameters 
            //var parameters = new List<Parameter>();
            //parameters.Add(new ResolvedParameter((p, c) => p.Name == "strategies",
            //                                     (p, c) => new List<IShippingStrategy>
            //                                     {
            //                                         c.ResolveKeyed<IShippingStrategy>(EShippingType.DHL.ToString()),
            //                                         c.ResolveKeyed<IShippingStrategy>(EShippingType.UPS.ToString()),
            //                                         c.ResolveKeyed<IShippingStrategy>(EShippingType.Sedexx.ToString()),
            //                                     }));

            //// resgiter proxy            
            //builder.RegisterType<ShippingStrategyProxy>().Named<IShippingStrategy>(EShippingType.Proxy.ToString()).WithParameters(parameters);

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