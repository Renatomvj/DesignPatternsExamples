using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.Factory_Method
{
    public class ProductB : IProduct
    {
        public string DoStuff()
        {
            return "{Result of ConcreteProduct2}";
        }
    }
}
