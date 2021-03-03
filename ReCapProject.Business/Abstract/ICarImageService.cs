using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;
using ReCapProject.Core.Utilities.Results;
using ReCapProject.Entities.Concrete;

namespace ReCapProject.Business.Abstract
{
    public interface ICarImageService
    {
        IResult Add(IFormFile file, CarImage carImage);
        IResult Delete(CarImage carImage);
        IResult Update(IFormFile file, CarImage carImage);
        IDataResult<CarImage> Get(int id);
        IDataResult<List<CarImage>> GetAll();
        IDataResult<List<CarImage>> GetImagesByCarId(int id);
    }
}
