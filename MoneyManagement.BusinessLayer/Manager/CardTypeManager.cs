using MoneyManagement.Contracts.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManagement.BusinessLayer.Manager
{
    public class CardTypeManager
    {
        public IList<CardType> Get()
        {
            IList<CardType> cardTypes = new List<CardType>();

            cardTypes.Add(new CardType() { Id = 1, Description = "Visa"});
            cardTypes.Add(new CardType() { Id = 2, Description = "Master Card" });

            return cardTypes;
        }
    }
}
