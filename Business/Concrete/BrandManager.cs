using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandService : IBrandService
    {
        private IBrandDal _brandDal;
        public BrandService(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public Brand Add(Brand brand)
        {
            throw new NotImplementedException();
        }

        public Brand Delete(Brand brand)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetCarsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public Brand Update(Brand brand)
        {
            throw new NotImplementedException();
        }
    }
}
