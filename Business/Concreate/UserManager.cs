using Business.Abstract;
using Business.Constants;
using Core.Entities.Concreate;
using Core.Utilities.Results;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;


namespace Business.Concreate
{
    public class UserManager : IUserService
    {
        readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(Messages.UserAdded);

        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.DeletedUser);
        }

        public IDataResult<User> GetById(int Id)
        {
            return new SuccessDataResult<User>(_userDal.GetBy(u => u.Id == Id), Messages.UserSelected);
        }

        public IDataResult<User> GetByMail(string Email)
        {
            return new SuccessDataResult<User>(_userDal.GetBy(user => user.Email == Email), Messages.UserWithThisMail);
        }

        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            return new SuccessDataResult<List<OperationClaim>>(_userDal.GetClaims(user),Messages.ClaimsCrossChecked);
        }

        public IDataResult<List<User>> GetlAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.UsersListed);
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.UserUpdated);
        }


    }
}
