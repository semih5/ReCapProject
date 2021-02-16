using Business.Abstract;
using Business.Constants;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserService _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public IResult AddUser(User user)
        {
            _userDal.AddUser(user);
            return new SuccessResult(Messages.Added);
        }

        public IResult DeleteUser(User user)
        {
            _userDal.DeleteUser(user);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<User>> GetAllUsers()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAllUsers(), Messages.Listed);
        }

        public IDataResult<User> GetById(int userId)
        {
            return new SuccessDataResult<User>(_userDal.GetAllUsers().SingleOrDefault(p => p.Id == userId));
        }

        public IResult UpdateUser(User user)
        {
            _userDal.UpdateUser(user);
            return new SuccessResult(Messages.Updated);
        }
    }
}
