using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.Memory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            //Add
            
            //Read
            ICarDal carDal = new InMemoryDal();
            CarManager carManager = new CarManager(carDal);

            Console.WriteLine("Cars; ");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.ModelYear + " " + car.Description + ". Daily Price;" + car.DailyPrice);
            }

            
            //Update

            //Delete




        }
    }
}
