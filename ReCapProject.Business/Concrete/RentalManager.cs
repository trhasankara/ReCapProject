using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReCapProject.Business.Abstract;
using ReCapProject.Core.Utilities.Results;
using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities.Concrete;

namespace ReCapProject.Business.Concrete
{
    public class RentalManager:IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(),"Kiralamalar listelendi");
        }

        public IDataResult<Rental> Get(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(p => p.Id == id),"Kiralama listelendi");
        }

        public IResult Add(Rental rental)
        {
            if (_rentalDal.GetAll(p => p.ReturnDate == null).Any())
            {
                return new ErrorResult("Araç teslim edilmediği için kiralanamaz");
            }
            _rentalDal.Add(rental);
            return new SuccessResult("Kiralama eklendi");
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult("Kiralama güncellendi");
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult("Kiralama silindi");
        }
    }
}
