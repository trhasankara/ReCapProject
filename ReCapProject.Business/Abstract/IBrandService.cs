using System;
using System.Collections.Generic;
using System.Text;
using ReCapProject.Entities.Concrete;

namespace ReCapProject.Business.Abstract
{
    public interface IBrandService
    {
        List<Brand> GetAll();
        Brand Get(int id);
        void Add(Brand entity);
        void Update(Brand entity);
        void Delete(Brand entity);
    }
}
