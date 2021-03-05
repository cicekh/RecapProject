using Core.Utilities.Results;
using Entities.Concreate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface ICarService
    {
        IDataResult<Car> GetById(int id);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);

        IDataResult<List<Car>> GetAll();

        IDataResult<List<Car>> GetCarsByBrandId(int Id);

        IDataResult<List<Car>> GetCarsByColorId(int Id);

        IDataResult<List<CarDetailDto>> GetCarsDetails();

    }
}
