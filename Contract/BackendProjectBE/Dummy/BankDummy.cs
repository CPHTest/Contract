using Contract.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendProjectBE.Dummy
{
    public class BankDummy : IBank
    {
        public void AddAccount(IAccount account)
        {
            throw new NotImplementedException();
        }

        public IAccount GetAccount(string id)
        {
            throw new NotImplementedException();
        }

        public List<IAccount> GetAccounts(ICustomer customer)
        {
            throw new NotImplementedException();
        }
    }
}
