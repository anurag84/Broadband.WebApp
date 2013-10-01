using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Broadband.Data.CustomerAccounts;

namespace Broadband.WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int AccountNumber = 123;

            ViewBag.Message = "Broadbandchoices Demo.";

            IContractCustomer ContractCustomer = new ProcessCustomer();

            ContractCustomer.AccountNumber = AccountNumber;
            ContractCustomer.Balance = 0;

            IMonthlyPayCustomer MonthlyCustomer = new ProcessCustomer();
            MonthlyCustomer.AccountNumber = AccountNumber;
            MonthlyCustomer.Balance = 1000; //Current balance

            TransferAccounts transferAccount = new TransferAccounts();
            //Transfer charges...
            transferAccount.Charges = 300;
            //12 Month Contract deposite amount...
            transferAccount.Deposit = 1200;

            transferAccount.Transfer(MonthlyCustomer, ContractCustomer);

            ViewBag.After= "Customer balance after transfer from Monthly to Contract :: " + MonthlyCustomer.Balance;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
