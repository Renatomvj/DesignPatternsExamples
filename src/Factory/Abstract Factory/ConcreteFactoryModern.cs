using DesignPatterns.Factory.Abstract_Factory.Couch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.Abstract_Factory
{
    public class ConcreteFactoryModern : AbstractFactory
    {
        public override IProductChair CreateProductChair()
        {
            return new ModernChair();
        }

        public override IProductCouch CreateProductCouch()
        {
            return new ModernCouch();
        }
    }
}
