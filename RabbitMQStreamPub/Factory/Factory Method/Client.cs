using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.Factory_Method
{
    public class Client
    {
        public void Main()
        {
            Console.WriteLine("APP: Lauched with the ConcreteCreatorA");
            ClientCode(new ConcreteCreatorA());

            Console.WriteLine("APP: Lauched with the ConcreteCreatorB");
            ClientCode(new ConcreteCreatorB());
        }

        private void ClientCode(Creator creator)
        {
            Console.WriteLine("Client: I'm not aware of the creator's class, but it still works. \n" + creator.SomeOperation());
        }
    }
}
