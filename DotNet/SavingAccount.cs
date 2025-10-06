using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet
{
    public class SavingAccount : BankBase
    {
        //public decimal Balance { get; set; }
        public SavingAccount(string name, decimal balance) : base(name, balance)
        {
        }

        public override decimal CalulateTax()
        {
            return Balance * (20.02m / 100);
        }
    }
}
