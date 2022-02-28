using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.Abstract_Factory
{
    public class Client
    {
        public void Main()
        {

            var style = GetStyle();           

            ShowProducts(style);            

        }

        private void ShowProducts(string style)
        {
            AbstractFactory abstractFactory;

            if (style.Equals("Modern"))
                abstractFactory = new ConcreteFactoryModern();
            else if (style.Equals("Victorian"))
                abstractFactory = new ConcreteFactoryVictorian();
            else
                throw new Exception("Error! Unknown operating system");

            var chair = abstractFactory.CreateProductChair();
            var couch = abstractFactory.CreateProductCouch();

            Console.WriteLine("Styles");
            Console.WriteLine("chair --> " + chair.Description());
            Console.WriteLine("couch --> " + couch.Description());
        }

        private string GetStyle()
        {
            var input = Console.ReadLine();
            return input.Trim();
        }
    }
}
