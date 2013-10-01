using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadband.Data.CustomerAccounts
{
    public class TransferAccounts
    {
        public decimal Deposit { get; set; }
        public decimal Charges { get; set; }

        public void Transfer(IMonthlyPayCustomer MonthlyPayCustomer, IContractCustomer ContractCustomer)
        {
            ContractCustomer.SetupAccount(Deposit);
            MonthlyPayCustomer.TransferToContract(Charges,ContractCustomer.Balance);
        } 
    }
}
