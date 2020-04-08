﻿using Contract.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DTO
{
    public class Customer : ICustomer
    {
        private string cpr;
        private string name;
        private string id;
        public Customer(string cpr, string name, string id)
        {
            this.cpr = cpr;
            this.name = name;
            this.id = id;
        }

        public void transfer(int amount, IAccount account, ICustomer target)
        {
        }

        public string getId()
        {
            return id;
        }
    }
}
