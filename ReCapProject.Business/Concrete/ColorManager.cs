using System;
using System.Collections.Generic;
using System.Text;
using ReCapProject.Business.Abstract;
using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities.Concrete;

namespace ReCapProject.Business.Concrete
{
    public class ColorManager:IColorService
    {
        IColorDal _colorDal;
        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Color Get(int id)
        {
            return _colorDal.Get(p => p.Id == id);
        }

        public void Add(Color entity)
        {
           _colorDal.Add(entity);
        }

        public void Update(Color entity)
        {
            _colorDal.Update(entity);
        }

        public void Delete(Color entity)
        {
            _colorDal.Delete(entity);
        }
    }
}
