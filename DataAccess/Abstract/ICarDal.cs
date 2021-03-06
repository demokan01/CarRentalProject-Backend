using Entities.Concrete;
using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.DTOs;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarDetailDto(Expression<Func<Car, bool>> filter = null);
    }
}