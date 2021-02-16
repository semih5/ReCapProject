using Core.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAllCustomers();
        IDataResult<Customer> GetById(int id);
        IResult AddCustomer(Customer customer);
        IResult UpdateCustomer(Customer customer);
        IResult DeleteCustomer(Customer customer);
    }
}
