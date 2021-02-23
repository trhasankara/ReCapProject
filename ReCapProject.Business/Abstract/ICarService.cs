using System;
using System.Collections.Generic;
using System.Text;
using ReCapProject.Entities.Concrete;

namespace ReCapProject.Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        Car Get(int id);
        void Add(Car entity);
        void Update(Car entity);
        void Delete(Car entity);

        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
        
    }
}
