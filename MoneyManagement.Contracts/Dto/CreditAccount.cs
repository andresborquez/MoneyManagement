using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManagement.Contracts.Dto
{
    public class CreditAccount : Account
    {
        [Required]
        [StringLength(19)]
        [CreditCard]
        public string Number { get; set; }

        [Required]
        public int CardTypeId { get; set; }

        public int GracePeriod { get; set; }

        [Range(1,31)]
        public int EndDayPeriod { get; set; }
    }
}
