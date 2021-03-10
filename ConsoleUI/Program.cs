using Business.Concrete;
using DataAccess.Concrete.Entity_Framework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager = new CarManager(new InMemoryCarDal());
            //foreach (var Car in carManager.GetAll()) 
            //{
            //    Console.WriteLine(Car.Description);
            //}

            CarManager carManager = new CarManager(new EfCarDal());
            if (carManager.Dailprice=)
            {

            }

        }
    }
}
