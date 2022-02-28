using DesignPatterns.Cases.Case1;
using DesignPatterns.Cases.Case1.Factories;
using System;
using Unity;

namespace DesignPatterns
{

    class ProgramCase1
    {
        static void MainC1(string[] args)
        {
            var container = ContainerCase1.Configure();

            var shippingFactory = container.Resolve<IShippingFactory>();

            Order order = new Order(EShippingMethods.UPS, orderTotal: 90, orderWeight: 12, orderZipCode: 98109);

            var shipping = shippingFactory.Create(order.ShippingMethod);
                                   
            Console.WriteLine(shipping.CalculateShippingCost(order));

            Console.ReadKey();
        }      
    }
}