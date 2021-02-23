using System;
using System.Collections.Generic;
using System.Text;
using ReCapProject.Entities.Concrete;

namespace ReCapProject.Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
        Color Get(int id);
        void Add(Color entity);
        void Update(Color entity);
        void Delete(Color entity);
    }
}
