using MoneyManagement.Contracts.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManagement.BusinessLayer.Manager
{
    public class CreditAccountManager
    {
        public IList<CreditAccount> Get()
        {
            IList<CreditAccount> creditAccounts;

            creditAccounts = new List<CreditAccount>();

            creditAccounts.Add(new CreditAccount() { Number = "492837637373739" });
            creditAccounts.Add(new CreditAccount() { Number = "492837637373739" });
            creditAccounts.Add(new CreditAccount() { Number = "492837637373739" });
            creditAccounts.Add(new CreditAccount() { Number = "492837637373739" });

            return creditAccounts;
        }

        public void Save(CreditAccount creditAccount)
        {
            return;
        }
    }
}
