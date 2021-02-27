using System;
using System.Collections.Generic;
using System.Text;
using ReCapProject.Core.Utilities.Results;
using ReCapProject.Entities.Concrete;

namespace ReCapProject.Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();
        IDataResult<Brand> Get(int id);
        IResult Add(Brand entity);
        IResult Update(Brand entity);
        IResult Delete(Brand entity);
    }
}
