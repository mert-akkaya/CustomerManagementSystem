using CustomerManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagementSystem.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Database added : "+customer.FirstName);
        }
    }
}
