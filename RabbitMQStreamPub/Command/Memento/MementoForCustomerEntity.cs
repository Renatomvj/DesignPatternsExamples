using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command.Memento
{
    public class MementoForCustomerEntity
    {
        private Customer _customer;
        public MementoForCustomerEntity(Customer customer)
        {
            _customer = customer.Clone();
        }

        public Customer GetCustomer()
        {
            return _customer;
        }
    }
}
