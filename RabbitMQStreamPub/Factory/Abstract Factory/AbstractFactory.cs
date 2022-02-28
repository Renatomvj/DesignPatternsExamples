using DesignPatterns.Factory.Abstract_Factory.Couch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.Abstract_Factory
{
    public abstract class AbstractFactory
    {
        public abstract IProductChair CreateProductChair();
        public abstract IProductCouch CreateProductCouch();
    }
}
