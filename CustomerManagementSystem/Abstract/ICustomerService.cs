using CustomerManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagementSystem.Abstract
{
    interface ICustomerService
    {
        void Save(Customer customer);
    }
}
