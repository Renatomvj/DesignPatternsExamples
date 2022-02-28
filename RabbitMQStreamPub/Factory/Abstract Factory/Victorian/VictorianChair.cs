using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.Abstract_Factory
{
    public class VictorianChair : IProductChair
    {
        public string Description()
        {
            return "VictorianChair";
        }

        public bool HasLegs()
        {
            throw new NotImplementedException();
        }

        public string SitOn()
        {
            throw new NotImplementedException();
        }
    }
}
