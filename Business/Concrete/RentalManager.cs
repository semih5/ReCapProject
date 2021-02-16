using Business.Abstract;
using Business.Constants;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalService _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult AddRental(Rental rental)
        {
            _rentalDal.AddRental(rental);
            return new SuccessResult(Messages.Added);
        }

        public IResult DeleteRental(Rental rental)
        {
            _rentalDal.DeleteRental(rental);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Rental>> GetAllRentals()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.Listed);
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails(), Messages.Listed);
        }

        public IResult UpdateRental(Rental rental)
        {
            _rentalDal.UpdateRental(rental);
            return new SuccessResult(Messages.Updated);
            }
    }
}
