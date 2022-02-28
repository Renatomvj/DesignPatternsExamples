using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.Abstract_Factory.Couch
{
    public interface IProductCouch
    {
        public bool HasLegs();
        public string SitOn();
        public string Description();
    }
}
