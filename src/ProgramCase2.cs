using DesignPatterns.Cases.Case2;
using DesignPatterns.Cases.Case2.Strategies;
using System;
using Unity;

namespace DesignPatterns
{

    class ProgramCase2
    {
        static void MainC2(string[] args)
        {
            var container = ContainerCase2.Configure();
            var shippingProxy = container.Resolve<IShippingStrategy>(EShippingMethods.Proxy.ToString());
            
            Order order = new Order(shippingMethod: EShippingMethods.DHL, orderTotal: 90, orderWeight: 12, orderZipCode: 98109);

            Console.WriteLine(shippingProxy.CalculateShippingCost(order));

            Console.ReadKey();
        }      
    }
}