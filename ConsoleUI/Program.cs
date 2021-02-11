using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.Memory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CRUD();
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarDetail())
            {
                Console.WriteLine("Id: {0} / Brand: {1} / Color: {2} / Price: {3}", car.Id, car.BrandName, car.ColorName, car.DailyPrice);
            }
        }

        private static void CRUD()
        {
            //Add
            CarManager carManager = new CarManager(new EfCarDal());
            Car car1 = new Car { BrandId = 256, ColorId = 125, DailyPrice = 250, Description = "New added car.", ModelYear = 2000 };
            carManager.Add(car1);

            //Read
            foreach (var x in carManager.GetAll())
            {
                Console.WriteLine(x.Description);


            }

            //Update

            carManager.Update(new Car
            {
                Id = 1005,
                BrandId = 257,
                Description = "Modified car.",
                ColorId = 126,
                ModelYear = 2020,
                DailyPrice = 769
            });

            //Delete
            carManager.Delete(car1);
        }
    }
}
