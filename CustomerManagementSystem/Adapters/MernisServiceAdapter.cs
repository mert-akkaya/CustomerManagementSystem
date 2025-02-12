﻿using CustomerManagementSystem.Abstract;
using CustomerManagementSystem.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementSystem.Adapters
{
    class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return TaskAsync(customer).Result;
        }
        public static async Task<bool> TaskAsync(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            var status = await (client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year));

            return status.Body.TCKimlikNoDogrulaResult;
        }
    }
}
