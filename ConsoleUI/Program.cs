using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.Memory;
using Entites.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarDal carDal = new InMemoryDal();
            CarManager carManager = new CarManager(carDal);

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine( car.ModelYear + " " + car.Description + ". Daily Price;" + car.DailyPrice);
            }


        }
    }
}
