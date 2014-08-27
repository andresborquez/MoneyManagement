using MoneyManagement.BusinessLayer.Manager;
using MoneyManagement.Contracts.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoneyManagement.Controllers.Accounts.Credit
{
    public class CreditAccountController : Controller
    {
        // GET: CreditAccount
        public ActionResult Index()
        {
            var creditAccountManager = new CreditAccountManager();

            var creditAccounts = creditAccountManager.Get();

            return View(creditAccounts);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CreditAccount creditAccount)
        {
            var creditAccountManager = new CreditAccountManager();

            if (ModelState.IsValid)
            {
                creditAccountManager.Save(creditAccount);

                return RedirectToAction("Index");
            }
            else
            {
                return View(creditAccount);
            }
        }
    }
}