﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManagement.Contracts.Dto
{
    public class Bank : IdDescriptionDto
    {
        public int CountryId { get; set; }
    }
}
