using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.Factory_Method
{
    public abstract class Creator
    {
        public abstract IProduct CreateProduct();
        
        public string SomeOperation()
        {
            var product = CreateProduct();
            var result = "Creator: The same creator's code has just worked with " + product.DoStuff();

            return result;

        }
    }
}
