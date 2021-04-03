using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concreate;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concreate.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, ReCapContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new ReCapContext())
            {
                var result = from operationClaims in context.OperationClaims
                             join userOperationClaims in context.UserOperationClaims
                             on operationClaims.Id equals userOperationClaims.OperationClaimId
                             where userOperationClaims.UserId == user.Id
                             select new OperationClaim { Id = operationClaims.Id, Name = operationClaims.Name };
                return result.ToList();
            }
        }
    }
}
