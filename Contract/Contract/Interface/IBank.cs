using Contract.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.Interface
{
    public interface IBank
    {
        public List<IAccount> GetAccounts(Customer customer);

        public IAccount GetAccount(string id);

        public void AddAccount(IAccount account);
    }
}

