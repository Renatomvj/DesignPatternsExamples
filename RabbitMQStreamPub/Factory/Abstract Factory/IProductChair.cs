using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.Abstract_Factory
{
    public interface IProductChair
    {
        public bool HasLegs();
        public string SitOn();
        public string Description();
    }
}
