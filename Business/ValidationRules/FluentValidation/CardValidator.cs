using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CardValidator:AbstractValidator<CreditCard>
    {
        public CardValidator()
        {
            //RuleFor(c => c.FirstName).NotEmpty();
            //RuleFor(c => c.LastName).NotEmpty();
            //RuleFor(c => c.CardNumber).NotEmpty();
            //RuleFor(c => c.ExpirationDate).NotEmpty();
            //RuleFor(c => c.CVV).NotEmpty();
        }
    }
}
