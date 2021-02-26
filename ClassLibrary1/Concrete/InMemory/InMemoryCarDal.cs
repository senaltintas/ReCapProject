using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            new Car { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 150000, ModelYear = 2021, Description = "BLACK BMW" },
            new Car { Id = 2, BrandId = 2, ColorId = 1, DailyPrice = 140000, ModelYear = 2021, Description = "BLACK MERCEDES" },
            new Car { Id = 3, BrandId = 2, ColorId = 2, DailyPrice = 130000, ModelYear = 2021, Description = "WHITE MERCEDES" },
            new Car { Id = 4, BrandId = 3, ColorId = 3, DailyPrice = 120000, ModelYear = 2021, Description = "GRAY AUDI" },
            new Car { Id = 5, BrandId = 4, ColorId = 4, DailyPrice = 70000, ModelYear = 2021, Description = "RED FIAT" },
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public bool Any(Func<Car, bool> filter)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car car)
        {
            
            Car  CarToDelete = _cars.SingleOrDefault(c =>c.Id==car.Id);
            _cars.Remove(CarToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.Description = car.Description;
            CarToUpdate.ModelYear = car.ModelYear;
        }
    }
}
