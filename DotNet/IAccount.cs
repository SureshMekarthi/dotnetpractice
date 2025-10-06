using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet
{
    internal interface IAccount
    {
         decimal CalulateTax(decimal balance);
        decimal GetBalanceAfterTax(decimal balance);
        void GetBankAccountDetails(string name, decimal balance);
    }
}
