using Business.Concrete;
using DataAccess.Concrete.Entity_Framework;
using System;

namespace ConsoleUI
{
    public class Program

    {
        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + "/" + car.BrandName); 
                }
                
                else
                {
                    Console.WriteLine(result.Message);
                }
            }
        }
       
    }
}
