using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Cases.Case4
{
    public class Order
    {

        public ShippingType ShippingType { get; private set; }
        public int OrderTotal { get; private set; }
        public int OrderWeight { get; private set; }
        public int OrderZipCode { get; private set; }

        public Order(ShippingType shippingMethod, int orderTotal, int orderWeight, int orderZipCode)
        {
            ShippingType = shippingMethod;
            OrderTotal = orderTotal;
            OrderWeight = orderWeight;
            OrderZipCode = orderZipCode;
        }

        public int CalculateShipping() => ShippingType.CalculateShipping(this);

    }
}
