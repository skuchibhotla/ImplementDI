using ImplementDI.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementDI
{
    class ConsoleApplication
    {
        private readonly ICustomer _customer;
        
        // Constructor
        public ConsoleApplication(ICustomer customer)
        {
            _customer = customer;
        }

        // Generic method
        public void Run()
        {
            _customer.CreateCustomer();
        }
    }
}
