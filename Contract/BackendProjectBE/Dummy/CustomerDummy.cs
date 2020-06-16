using Contract.DTO;
using Contract.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendProjectBE.Dummy
{
    public class CustomerDummy : ICustomer
    {
        public CustomerDummy()
        {

        }
        public string getId()
        {
            throw new NotImplementedException();
        }

        public void transfer(int amount, IAccount account, ICustomer target)
        {
            throw new NotImplementedException();
        }
    }
}
