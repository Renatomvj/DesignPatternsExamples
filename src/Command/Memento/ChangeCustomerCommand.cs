using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command.Memento
{
    public class ChangeCustomerCommand : IDbCommand
    {
        public Customer Customer { get; private set; }

        private readonly List<MementoForCustomerEntity> _mementos = new List<MementoForCustomerEntity>();

        public ChangeCustomerCommand(Customer customer)
        {
            this.Customer = customer;
        }

        public void Execute(string newName)
        {
            _mementos.Add(new MementoForCustomerEntity(Customer));
            Customer.Name = newName;
        }

        public void UnExecute()
        {
            Customer = (_mementos[_mementos.Count - 1].GetCustomer());
            _mementos.RemoveAt(_mementos.Count - 1);
        }
    }
}
