using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Cases.Case2.Services
{
    public interface IWeightMappingService
    {
        int DeterminePrice(Order order);
    }
}
