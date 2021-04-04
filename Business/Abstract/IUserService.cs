using Core.Entities.Concreate;
using Core.Utilities.Results;
using System.Collections.Generic;


namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<OperationClaim>> GetClaims(User user);

        IResult Add(User user);
        IDataResult<User> GetByMail(string email);
      
        IResult Update(User user);
        IResult Delete(User user);

        IDataResult<List<User>> GetlAll();

        IDataResult<User> GetById(int Id);
    }
}
 