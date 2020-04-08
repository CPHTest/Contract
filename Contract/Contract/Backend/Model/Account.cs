using Contract.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DTO
{
    public class Account 
    {
        private string number;
        private long balance = 500;

        public string Number { get { return number; } set { number = value; } }
        public long Balance { get { return balance; } set { balance = value; } }

        public Account(string number)
        {
            this.number = number;
        }

       
    }
}
