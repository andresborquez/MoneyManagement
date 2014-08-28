using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManagement.Contracts.Dto
{
    public class Account
    {
        [Required]
        public int BankId { get; set; }
    }
}
