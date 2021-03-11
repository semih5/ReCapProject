using Business.Concrete;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
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

            foreach (var car in carManager.GetCarDetails().Data)
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
            foreach (var x in carManager.GetAll().Data)
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

            // GetCarsByBrandId
            foreach (var x in carManager.GetCarsByBrandId(256).Data)
            {
                Console.WriteLine(x.Description);
            }

            // GetCarsByColorId
            foreach (var x in carManager.GetCarsByColorId(2).Data)
            {
                Console.WriteLine(x.BrandId);
            }

            // GetById
            Console.WriteLine(carManager.GetById(3002).Data.ModelYear);

        }

        private static void AddCustomer()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            Customer cr2 = new Customer { CustomerId = 1, CustomerCompanyName = "SMH" };
            Console.WriteLine(customerManager.AddCustomer(cr2).Message);
        }

        private static void AddUser()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            User cr1 = new User { FirstName = "JSN", LastName = "BRWN", Email = "default"};
            Console.WriteLine(userManager.AddUser(cr1).Message);
        }


    }

}
