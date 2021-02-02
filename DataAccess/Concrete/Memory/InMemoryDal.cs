using DataAccess.Abstract;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.Memory
{
    public class InMemoryDal: ICarDal
    {
        List<Car> _cars;
        public InMemoryDal()
        {
            _cars = new List<Car>
            {
            new Car { Id = 1, BrandId = 1, ColorId = 1, ModelYear = 2020, DailyPrice = 90, Description = "Renault" },
            new Car { Id = 2, BrandId = 2, ColorId = 2, ModelYear = 2021, DailyPrice = 100, Description = "Renault"},
            new Car { Id = 3, BrandId = 3, ColorId = 1, ModelYear = 2019, DailyPrice = 85, Description = "Fiat"},
            new Car { Id = 4, BrandId = 1, ColorId = 3, ModelYear = 2018, DailyPrice = 75, Description = "Opel"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(car);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == c.Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

    }
}
