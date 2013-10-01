using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadband.Data.CustomerAccounts
{
    public class ProcessCustomer : IMonthlyPayCustomer,IContractCustomer
    {
        public long AccountNumber { get; set; }
        public decimal Balance { get; set; }
        
        public void SetupAccount(decimal value)
        {
            Balance += value;
        } 

        //£1000 charges are applicable on tranferring account to Contract.
        public void TransferToContract(decimal value,decimal carryForwardBalance)
        {
            Balance = Balance + carryForwardBalance - value;
        }
       
    }
}
