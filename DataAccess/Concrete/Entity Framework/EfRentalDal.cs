using Core.DataAccess.EntityFramework;
using Core.DataAccsess;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.Entity_Framework
{
   public  class EfRentalDal:EfEntityRepositoryBase<Rental, RentACarContext> IRentalDal
    {

    }
}
