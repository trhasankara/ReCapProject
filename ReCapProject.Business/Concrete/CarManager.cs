using System;
using System.Collections.Generic;
using System.Text;
using ReCapProject.Business.Abstract;
using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities.Concrete;

namespace ReCapProject.Business.Concrete
{
    public class CarManager:ICarService
    {
        ICarDal _carDal;
        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car Get(int id)
        {
            return _carDal.Get(p=>p.Id==id);
        }

        public void Add(Car car)
        {
            if (car.Name.Length < 2)
            {
                new Exception("Araç ismi en az 2 karakterden oluşmalıdır!");
            }
            if (car.DailyPrice < 0)
            {
                new Exception("Aracın kiralama ücreti 0 dan büyük olmaldır!");
            }
            _carDal.Add(car);
        }

        public void Update(Car car)
        {
           _carDal.Update(car);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(p=>p.BrandId==id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(p => p.ColorId == id);
        }
    }
}
