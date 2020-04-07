using Contract.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.Interface
{
    public interface IAccount
    {
        public string Number { get; set; }
        public long Balance { get; set; }

        IBank getBank();

        ICustomer getCustomer();

        string getNumber();

        long getBalance();

        void Transfer(long amount, IAccount target);

        void Transfer(long amount, string targetNumber);

        void Deposit(IAccount target, long amount);

        void Withdrawal(long amount, IAccount target);

    }
}
