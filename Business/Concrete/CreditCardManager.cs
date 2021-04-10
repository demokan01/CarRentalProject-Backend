using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Design;

namespace Business.Concrete
{
    public class CreditCardManager : ICreditCardService
    {
        private ICreditCardDal _iCreditCardDal;

        public CreditCardManager(ICreditCardDal iCreditCardDal)
        {
            _iCreditCardDal = iCreditCardDal;
        }

        public IResult Add(CreditCard creditCard)
        {
            _iCreditCardDal.Add(creditCard);
            return new SuccessResult();
        }

        public IDataResult<List<CreditCard>> GetAll()
        {
            return new SuccessDataResult<List<CreditCard>>(_iCreditCardDal.GetAll(), Messages.SuccessMessage);
        }

        public IDataResult<CreditCard> GetById(int creditCardId)
        {
            return new SuccessDataResult<CreditCard>(_iCreditCardDal.Get(c => c.Id == creditCardId), Messages.SuccessMessage);
        }
    }
}