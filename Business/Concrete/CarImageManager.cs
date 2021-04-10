using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        private ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }


        //[ValidationAspect(typeof(CarImagesValidator))]
        public IResult Add(IFormFile file, CarImage carImage)
        {
            IResult result = BusinessRules.Run(
                CheckImagesLimit(carImage.CarId)
                );
            if (result != null)
            {
                return result;
            }
            carImage.ImagePath = FileHelper.Add(file);
            carImage.Date = DateTime.Now;
            _carImageDal.Add(carImage);
            return new SuccessResult();
        }

        public IResult Delete(CarImage carImage)
        {
            IResult result = BusinessRules.Run(CarImageDelete(carImage));
            if (result != null)
            {
                return result;
            }
            _carImageDal.Delete(carImage);
            return new SuccessResult();
        }

        //[ValidationAspect(typeof(CarImagesValidator))]
        public IDataResult<CarImage> Get(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(c => c.Id == id));
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        //[ValidationAspect(typeof(CarImagesValidator))]
        public IDataResult<List<CarImage>> GetImageByCarId(int id)
        {
            IResult result = BusinessRules.Run(CheckIfCarImageNull(id));
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(c => c.CarId == id));
        }

        //[ValidationAspect(typeof(CarImagesValidator))]
        public IResult Update(IFormFile file, CarImage carImages)
        {
            carImages.ImagePath = FileHelper.Update(_carImageDal.Get(c => c.Id == carImages.Id).ImagePath, file);
            carImages.Date = DateTime.Now;
            _carImageDal.Update(carImages);
            return new SuccessResult();
        }

        private IResult CheckImagesLimit(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarId == carId).Count;
            if (result >= 5)
            {
                return new ErrorResult(Messages.ImageLimit);
            }
            return new SuccessResult();
        }

        private IResult CheckIfCarImageNull(int id)
        {
            string path = System.IO.Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).FullName + @"\Images\carImages\default.png");
            var result = _carImageDal.GetAll(c => c.CarId == id).Any();
            if (!result)
            {
                new List<CarImage> { new CarImage { CarId = id, ImagePath = path, Date = DateTime.Now } };
                return new SuccessResult();
            }
            return new SuccessResult();
        }
        private IResult CarImageDelete(CarImage carImages)
        {
            try
            {
                File.Delete(carImages.ImagePath);
            }
            catch (Exception exception)
            {
                return new ErrorResult(exception.Message);
            }
            return new SuccessResult();
        }
    }
}
