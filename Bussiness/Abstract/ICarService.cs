using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface ICarService
    {
        Car GetById(int id);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        List<Car> GetAll();

        List<Car> GetCarsByBrandId(int Id);

        List<Car> GetCarsByColorId(int Id);
    }
}
