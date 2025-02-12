﻿using CustomerManagementSystem.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagementSystem.Entities
{
    public class Customer:IEntities
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }
    }
}
