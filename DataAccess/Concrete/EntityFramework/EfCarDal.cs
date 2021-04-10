using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalDBContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetailDto(Expression<Func<Car, bool>> filter = null)
        {
            using (CarRentalDBContext context = new CarRentalDBContext())
            {
                var result = from c in filter == null ? context.Cars : context.Cars.Where(filter)
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join color in context.Colors
                             on c.ColorId equals color.ColorId
                             join img in context.CarImages
                             on c.Id equals img.CarId
                             select new CarDetailDto
                             {
                                 CarId = c.Id,
                                 CarName=c.CarName,
                                 ModelYear = c.ModelYear,
                                 BrandName = b.BrandName,
                                 ColorName = color.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description,
                                 ImagePath = img.ImagePath,
                                 
                             };
                return result.ToList();
            }
        }
    }


}