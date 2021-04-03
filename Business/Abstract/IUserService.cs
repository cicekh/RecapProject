using Core.Utilities.Results;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        User GetByMail(string email);
      
        IResult Update(User user);
        IResult Delete(User user);

        IDataResult<List<User>> GetlAll();

        IDataResult<User> GetById(int Id);
    }
}
 