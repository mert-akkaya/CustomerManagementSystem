using CustomerManagementSystem.Abstract;
using CustomerManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagementSystem.Concrete
{
    class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
