using System;
using System.Collections.Generic;
using System.Text;
using ReCapProject.Business.Abstract;
using ReCapProject.Core.Utilities.Results;
using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities.Concrete;

namespace ReCapProject.Business.Concrete
{
    public class UserManager:IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(),"Kullanıcılar listelendi");
        }

        public IDataResult<User> Get(int id)
        {
            return new SuccessDataResult<User>(_userDal.Get(p=>p.Id==id), "Kullanıcı listelendi");
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult("Kullanıcı eklendi");
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult("Kullanıcı güncellendi");
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult("Kullanıcı silindi");
        }
    }
}
