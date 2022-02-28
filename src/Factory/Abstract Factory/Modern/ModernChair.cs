using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.Abstract_Factory
{
    public class ModernChair : IProductChair
    {
        public string Description()
        {
            return "ModernChair";
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
