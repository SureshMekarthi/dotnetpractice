using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet
{
    public class CurrentAccount : BankBase
    {
        public CurrentAccount(string name, decimal balance) : base(name, balance)
        {
        }

        public override decimal CalulateTax()
        {
            return Balance * (10.02m / 100);
        }
    }
}
