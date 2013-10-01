using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadband.Data.CustomerAccounts
{
    public interface IMonthlyPayCustomer
    {
        long AccountNumber { get; set; }
        decimal Balance { get; set; }
        void TransferToContract(decimal value,decimal carryForwardBalance); 
    }
}
