using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    interface IRouteStrategy
    {
        int Execute(int a, int b);
    }
}
