using Contract.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.DTO
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
            // _Hvad skal den gøre?_
        }

        public string getId()
        {
            return id;
        }
    }
}
