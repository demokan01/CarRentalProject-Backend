using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class CreditCard : IEntity
    {
        public int Id { get; set; }
        public string CardNo { get; set; }
        public string CardName { get; set; }
        public string ExpirationDate { get; set; }
        public string CVV { get; set; }

    }
}