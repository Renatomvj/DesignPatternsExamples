using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class RoadStrategy : IRouteStrategy
    {
        public int Execute(int a, int b)
        {
            return a + b;
        }
    }
}
