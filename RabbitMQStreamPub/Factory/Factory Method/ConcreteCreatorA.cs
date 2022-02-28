using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.Factory_Method
{
    public class ConcreteCreatorA : Creator
    {
        public override IProduct CreateProduct()
        {
            return new ProductA();
        }
    }
}
