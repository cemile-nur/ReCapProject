using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByCarId(int id);
        Car Add(Car car);
        Car Delete(Car car);
        Car Update(Car car);
        public List<CarDetailDto> GetCarDetails();
    }
}
