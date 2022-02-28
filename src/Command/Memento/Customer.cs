using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command.Memento
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer Clone()
        {
            return MemberwiseClone() as Customer;
        }
    }
}
