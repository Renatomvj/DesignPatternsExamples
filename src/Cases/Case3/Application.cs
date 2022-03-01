using DesignPatterns.Cases.Case3.Strategies;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac.Extras.AttributeMetadata;
using Autofac.Features.AttributeFilters;

namespace DesignPatterns.Cases.Case3
{
    public class Application
    {
        private readonly IShippingStrategy _shippingStrategy;
        public Application([KeyFilter(nameof(EShippingMethods.Proxy))] IShippingStrategy shippingStrategy)
        {
            this._shippingStrategy = shippingStrategy;
        }
        public void Run()
        {
            Order order = new Order(shippingMethod: EShippingMethods.UPS, orderTotal: 90, orderWeight: 12, orderZipCode: 98109);

            Console.WriteLine(_shippingStrategy.CalculateShippingCost(order));
        }
    }
}
