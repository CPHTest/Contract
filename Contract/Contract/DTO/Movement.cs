using Contract.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.DTO
{
    public class Movement
    {
        private IAccount source;
        private IAccount target;
        private DateTime time;
        private long amount;

        public Movement(IAccount accountSource, IAccount accountTarget, DateTime timeOfTransfer, long transferedAmount)
        {
            this.source = accountSource;
            this.target = accountTarget;
            this.time = timeOfTransfer;
            this.amount = transferedAmount;
        }


        public IAccount Source
        {
            get { return source; }
        }
        public IAccount Target
        {
            get { return target; }
        }
        public long Amount
        {
            get { return amount; }
        }
    }
}
