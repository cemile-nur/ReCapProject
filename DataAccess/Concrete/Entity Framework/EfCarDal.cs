using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.Entity_Framework
{
    
    
        public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
        {
            public List<CarDetailDto> GetCarDetails()
            {
                using (RentACarContext context = new RentACarContext())
                {
                    var result = from c in context.Cars
                                 join b in context.Brands
                                 on c.BrandId equals b.BrandId
                                 join r in context.Colors
                                 on c.ColorId equals r.ColorId
                                 select new CarDetailDto
                                 {
                                     BrandId = b.BrandId,
                                     BrandName = b.BrandName,
                                     DailyPrice = c.DailyPrice,
                                     ColorName = r.ColorName,
                                     Description = c.Description,
                                     CarId = c.CarId
                                 };
                    return result.ToList();
                }
            }
        }
}
