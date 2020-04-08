using Contract.DTO;
using Contract.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.Backend
{
    class API : IAPI
    {
        public void AddAccount(Account account, Bank bank)
        {
            throw new NotImplementedException();
        }

        public void deleteAccount(string accountId)
        {
            throw new NotImplementedException();
        }

        public IAccount GetAccount(string accountNumber)
        {
            throw new NotImplementedException();
        }

        public List<IAccount> GetAccounts(string bankCvrNumber)
        {
            throw new NotImplementedException();
        }

        public Bank GetBank(string cvr)
        {
            throw new NotImplementedException();
        }

        public List<ICustomer> GetCustomers(string bankCvrNumber)
        {
            throw new NotImplementedException();
        }
    }
}
