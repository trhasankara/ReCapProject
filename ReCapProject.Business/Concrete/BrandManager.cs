using System;
using System.Collections.Generic;
using System.Text;
using ReCapProject.Business.Abstract;
using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities.Concrete;

namespace ReCapProject.Business.Concrete
{
    public class BrandManager:IBrandService
    {
        IBrandDal _brandDal;
        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand Get(int id)
        {
            return _brandDal.Get(p=>p.Id==id);
        }

        public void Add(Brand entity)
        {
            _brandDal.Add(entity);
        }

        public void Update(Brand entity)
        {
            _brandDal.Update(entity);
        }

        public void Delete(Brand entity)
        {
            _brandDal.Delete(entity);
        }
    }
}
