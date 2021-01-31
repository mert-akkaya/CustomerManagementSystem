using CustomerManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagementSystem.Abstract
{
    interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
