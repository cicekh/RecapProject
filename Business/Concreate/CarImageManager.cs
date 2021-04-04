using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concreate;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concreate
{
    public class CarImageManager : ICarImageService
    {
        readonly IPhotoDal _photoDal;

        public CarImageManager(IPhotoDal photoDal)
        {
            _photoDal = photoDal;
        }

        //[ValidationAspect(typeof(CarImageValidator))]
        
        [SecuredOperation("admin,editor")]
        public IResult Add(IFormFile file, Photo carImage)
        {
            IResult result = BusinessRules.Run(CheckIfImageLimitExceeded(carImage.CarId));
            if (result != null)
            {
                return result;
            }
            carImage.ImagePath = FileHelper.Add(file);
            carImage.Date = DateTime.Now;
            _photoDal.Add(carImage);
            return new SuccessResult(Messages.CarImageAdded);

        }


        public IResult Delete(Photo carImage)
        {
            IResult result = BusinessRules.Run(DeleteCarImage(carImage));
            if (result != null)
            {
                return result;
            }
            _photoDal.Delete(carImage);
            return new SuccessResult(Messages.CarImageDeletedFromDB);

        }


        public IDataResult<List<Photo>> GetAll()
        {
            return new SuccessDataResult<List<Photo>>(_photoDal.GetAll());
        }

        public IDataResult<Photo> GetById(int carId)
        {
            return new SuccessDataResult<Photo>(_photoDal.GetByPropertyOf(p => p.CarId == carId));
        }

        public IResult Update(IFormFile file, Photo carImage)
        {
            var oldImagePath = _photoDal.GetByPropertyOf(p => p.Id == carImage.Id).ImagePath;
            _photoDal.Update(carImage);
            FileHelper.Update(oldImagePath, file);
            return new SuccessResult(Messages.carImageUpdated);
        }

        public IDataResult<List<Photo>> GetImagesOfACar(int carId)
        {
            return new SuccessDataResult<List<Photo>>(CheckIfAnyPictureExist(carId),Messages.ImagesofTheCarListed);  
        }

        private List<Photo> CheckIfAnyPictureExist(int carId)
        {
            string AnonimPhotoPath = Environment.CurrentDirectory + @"\static\images\logo.png";
            var result = _photoDal.GetAll(i => i.CarId == carId);
            if (result.Count <= 0)
            {
                return new List<Photo> { new Photo { ImagePath = AnonimPhotoPath, Date = DateTime.Now } };

            }
            return result;
        }

        private IResult CheckIfImageLimitExceeded(int carId)
        {
            var result = _photoDal.GetAll(p => p.CarId == carId);
            if (result.Count >= 5)
            {
                return new ErrorResult(Messages.CarImageLimitExceeded);
            }
            return new SuccessResult();
        }

        private IResult DeleteCarImage(Photo carImage)
        {
            try
            {
                FileHelper.Delete(carImage.ImagePath);
            }
            catch (Exception)
            {
                return new ErrorResult(Messages.CarDeletedError);
            }
            return new SuccessResult(Messages.CarImageDeletedFromSource);
        }

    }
}
