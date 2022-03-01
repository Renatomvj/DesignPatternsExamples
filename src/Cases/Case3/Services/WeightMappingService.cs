using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Cases.Case3.Services
{
    public class WeightMappingService : IWeightMappingService
    {
        public int DeterminePrice(Order order)
        {
            return 100;
        }
    }
}
