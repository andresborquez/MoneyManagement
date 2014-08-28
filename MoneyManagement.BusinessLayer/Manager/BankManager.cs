using MoneyManagement.Contracts.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManagement.BusinessLayer.Manager
{
    public class BankManager
    {
        public IList<Bank> Get()
        {
            IList<Bank> banks = new List<Bank>();

            banks.Add(new Bank() { Id = 1, Description = "HSBC", CountryId = 1 });

            return banks;
        }
    }
}
