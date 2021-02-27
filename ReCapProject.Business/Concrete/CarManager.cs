﻿using System;
using System.Collections.Generic;
using System.Text;
using ReCapProject.Business.Abstract;
using ReCapProject.Business.Constants;
using ReCapProject.Core.Utilities.Results;
using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities.Concrete;

namespace ReCapProject.Business.Concrete
{
    public class CarManager:ICarService
    {
        ICarDal _carDal;
        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 2)
            {
               return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarListed);
        }

        public IDataResult<Car> Get(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p => p.Id == id));
        }

        public IResult Add(Car car)
        {
            if (car.Name.Length < 2)
            {
                return new ErrorResult(Messages.CarNameInvalid);
            }
            if (car.DailyPrice < 0)
            {
                return new ErrorResult("Aracın kiralama ücreti 0 dan büyük olmaldır!");
            }
            _carDal.Add(car);
            return new Result(true,Messages.CarAdded);
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new Result(true,"Araç Güncellendi");
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new Result(true, "Araç Silindi");
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == id));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == id));
        }
    }
}
