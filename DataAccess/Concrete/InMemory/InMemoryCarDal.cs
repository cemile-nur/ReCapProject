using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> 
            {
                new Car{CarId=1, BrandId=1, ColorId=1, ModelYear=1999, DailyPrice=150, Description="Gunluk"},
                new Car{CarId=2, BrandId=2, ColorId=1, ModelYear=1999, DailyPrice=550, Description="Gunluk"},
                new Car{CarId=3, BrandId=1, ColorId=2, ModelYear=1999, DailyPrice=150, Description="Gunluk"},
                new Car{CarId=4, BrandId=2, ColorId=3, ModelYear=2000, DailyPrice=350, Description="Gunluk"},
                new Car{CarId=5, BrandId=2, ColorId=1, ModelYear=1999, DailyPrice=150, Description="Gunluk"},
                new Car{CarId=6, BrandId=1, ColorId=3, ModelYear=3021, DailyPrice=450, Description="Gunluk"},

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car productToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            _cars.Remove(productToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByCarId(int id)
        {
            return _cars.Where(c => c.CarId == id).ToList();
        }

        public void Update(Car car)
        {
            //Gönderdiğim ürün ıd sine sahip olan listedeki ürünü bul
            Car productToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            productToUpdate.BrandId = car.BrandId;
            productToUpdate.CarId = car.CarId;
            productToUpdate.ColorId = car.ColorId; 
            productToUpdate.DailyPrice = car.DailyPrice;
            productToUpdate.Description = car.Description;

        }
    }
}
