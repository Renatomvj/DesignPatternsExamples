using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.Abstract_Factory.Couch
{
    public class VictorianCouch : IProductCouch
    {
        public string Description()
        {
            return "VictorianCouch";
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
