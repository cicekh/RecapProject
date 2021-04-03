using DataAccess.Abstract;
using Entities.Concreate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Concreate.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car() { Id=1,BrandId=1,ColorId=1,DailyPrice=120,ModelYear=2011,Description="çok yahşidir." },
                new Car() {Id=2,BrandId=2,ColorId=3,DailyPrice=150,ModelYear=2012,Description="daha yahşidir."} ,
                  new Car() {Id=3,BrandId=1,ColorId=4,DailyPrice=180,ModelYear=2013,Description="en yahşidir."} ,
            };

        }
        public void Add(Car car)
        {
            Console.WriteLine("Car added!");
        }

        public void Delete(Car car)
        {
            Console.WriteLine("Car deleted!");
        }

        public List<Car> GetAll()
        {
            Console.WriteLine("Cars listed!");
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            Console.WriteLine("Car selected!");
            return new Car();
        }

        public Car GetById(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarsDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Console.WriteLine("Car updated!");
        }
    }
}
