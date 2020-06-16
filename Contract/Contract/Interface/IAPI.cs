using Contract.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.Interface
{
    public interface IAPI
    {
       IBank GetBank(string cvr);
        IAccount GetAccount(string accountNumber);
        List<IAccount> GetAccounts(string bankCvrNumber);
        List<ICustomer> GetCustomers(string bankCvrNumber);
        void AddAccount(IAccount account, IBank bank);
        void deleteAccount(string accountId);

    }
}
