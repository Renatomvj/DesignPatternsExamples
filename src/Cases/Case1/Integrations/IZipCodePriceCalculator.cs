using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Cases.Case1.Integrations
{
    public interface IZipCodePriceCalculator
    {
        public int CalculateShippingCost(int zipCode);
    }
}
