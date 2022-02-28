using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Cases.Case2
{
    public class Order
    {

        public EShippingMethods ShippingMethod { get; private set; }
        public int OrderTotal { get; private set; }
        public int OrderWeight { get; private set; }
        public int OrderZipCode { get; private set; }

        public Order(EShippingMethods shippingMethod, int orderTotal, int orderWeight, int orderZipCode)
        {
            ShippingMethod = shippingMethod;
            OrderTotal = orderTotal;
            OrderWeight = orderWeight;
            OrderZipCode = orderZipCode;
        }

    }
}
