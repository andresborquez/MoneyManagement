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
            var bankManager = new BankManager();
            var cardTypeManager = new CardTypeManager();
            
            var banks = bankManager.Get();
            var cardTypes = cardTypeManager.Get();

            ViewBag.Banks = new SelectList(banks, "Id", "Description");
            ViewBag.CardTypes = new SelectList(cardTypes, "Id", "Description");

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