using DesignPatterns.Factory.Abstract_Factory.Couch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.Abstract_Factory
{
    public class ConcreteFactoryVictorian : AbstractFactory
    {
        public override IProductChair CreateProductChair()
        {
            return new VictorianChair();
        }

        public override IProductCouch CreateProductCouch()
        {
            return new VictorianCouch();
        }
    }
}
