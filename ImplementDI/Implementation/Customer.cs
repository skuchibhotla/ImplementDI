using ImplementDI.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementDI.Implementation
{
    public class Customer : ICustomer
    {
        public void CreateCustomer()
        {
            Console.WriteLine("Creating a customer with concrete class injected using constuctor injection.");
        }
    }
}
