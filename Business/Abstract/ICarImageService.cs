using Core.Utilities.Results;
using Entities.Concreate;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IResult Add(IFormFile file, Photo carImage);
        IResult Update(IFormFile file, Photo carImage);
        IResult Delete(Photo carImage);
        IDataResult<List<Photo>> GetAll();
        IDataResult<Photo> GetById(int photoID);

        IDataResult<List<Photo>> GetImagesOfACar(int carId);

    }
}
