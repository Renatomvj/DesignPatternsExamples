using DesignPatterns.Cases.Case1.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Cases.Case1.Factories
{
    public interface IShippingFactory
    {
        IShippingStrategy Create(EShippingMethods method);
    }
}
