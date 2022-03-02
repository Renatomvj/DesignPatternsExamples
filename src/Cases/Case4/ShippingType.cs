using Ardalis.SmartEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Cases.Case4
{
    public abstract class ShippingType : SmartEnum<ShippingType>
    {
        private ShippingType(string name, int value) : base(name, value)
        {
        }

        public static readonly ShippingType Proxy = new ProxyType();
        public static readonly ShippingType DHL = new DHLType();
        public static readonly ShippingType UPS = new UPSType();
        public static readonly ShippingType Sedexx = new SedexxType();


        public abstract int CalculateShipping(Order order);

        private class ProxyType : ShippingType
        {
            public ProxyType():base(nameof(Proxy), 1)
            { }

            public override int CalculateShipping(Order order)
            {
                return 1;
            }

        }
        private class DHLType : ShippingType
        {
            public DHLType() : base(nameof(DHL), 2)
            { }

            public override int CalculateShipping(Order order)
            {
                return 1;
            }

        }
        private class UPSType : ShippingType
        {
            public UPSType() : base(nameof(UPS), 2)
            { }

            public override int CalculateShipping(Order order)
            {
                return 1;
            }

        }
        private class SedexxType : ShippingType
        {
            public SedexxType() : base(nameof(Sedexx), 3)
            { }

            public override int CalculateShipping(Order order)
            {
                return 1;
            }

        }
    }
 
}

