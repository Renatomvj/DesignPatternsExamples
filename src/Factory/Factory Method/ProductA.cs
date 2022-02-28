using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.Factory_Method
{
    public class ProductA : IProduct
    {
        public string DoStuff()
        {
            return "{Result of ConcreteProduct1}";
        }
    }
}
