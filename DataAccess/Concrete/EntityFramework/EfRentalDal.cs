using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarsInfoContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (CarsInfoContext context = new CarsInfoContext())
            {
                var result = from re in context.Rental
                             join ca in context.Cars on re.RentalCarId equals ca.Id
                             join cu in context.Customer on re.RentalCustomerId equals cu.CustomerId
                             join us in context.Users on cu.CustomerId equals us.UserId
                             select new RentalDetailDto
                             {
                                 CarId = ca.Id,
                                 Id = re.RentalId,
                                 CustomerName = cu.CustomerCompanyName,
                                 RentDate = re.RentDate,
                                 ReturnDate = re.ReturnDate
                             };
                             
                return result.ToList();

            }
        }
    }
}
