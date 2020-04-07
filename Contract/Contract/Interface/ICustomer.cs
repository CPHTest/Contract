using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract.DTO;

namespace Contract.Interface
{
    public interface ICustomer
    {
        void transfer(int amount, IAccount account, ICustomer target);

        string getId();
    }
}
