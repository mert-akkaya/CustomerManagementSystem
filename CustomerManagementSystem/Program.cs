using CustomerManagementSystem.Abstract;
using CustomerManagementSystem.Adapters;
using CustomerManagementSystem.Concrete;
using System;

namespace CustomerManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Entities.Customer { Id = 1, FirstName = "Mert",
                LastName = "Akkaya", DateOfBirth = new DateTime(2000, 11, 21),
                NationalityId = "10061591058" });
        }
    }
}
