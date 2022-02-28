using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command.Memento
{
    public class MementoClient
    {
        public void Execute()
        {
            var originalName = "John Travis";
            var cust = new Customer { Id = 5, Name = originalName };
            var cmd = new ChangeCustomerCommand(cust);
            var newName = "Billy Bob";
            cmd.Execute(newName);
            cmd.UnExecute();

        }
    }
}
