using DesignPatterns.Cases.Case4.Strategies;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac.Extras.AttributeMetadata;
using Autofac.Features.AttributeFilters;

namespace DesignPatterns.Cases.Case4
{
    public class Application
    {        
        public Application()
        {            
        }
        public void Run()
        {
            Order order = new Order(shippingMethod: ShippingType.UPS, orderTotal: 90, orderWeight: 12, orderZipCode: 98109);

            Console.WriteLine(order.CalculateShipping());
        }
    }
}
