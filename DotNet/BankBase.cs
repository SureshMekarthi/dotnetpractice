using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet
{
    public abstract class BankBase
    {
        public string AccountHolder { get; set; }
        public string AccountName { get; set; }
        public decimal Balance { get; set; }

        protected BankBase(string name, decimal balance)
        {
            AccountHolder = name;
            Balance = balance;
        }

        public abstract decimal CalulateTax();

        public decimal GetBalance(decimal balance) 
        {
            return Balance;
        }
       
        
    }
}
