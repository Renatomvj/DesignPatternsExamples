using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    internal class Navagatior
    {
        private IRouteStrategy _routeStrategy;

        public void SetStrategy(IRouteStrategy strategy)
        {
            this._routeStrategy = strategy;
        }

        public int ExecuteStrategy(int a, int b)
        {
            return _routeStrategy.Execute(a, b);
        }
        
    }
}
