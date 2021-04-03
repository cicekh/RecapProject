using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concreate;


namespace DataAccess.Concreate.EntityFramework
{
    public class EfPhotoDal: EfEntityRepositoryBase<Photo,ReCapContext>,IPhotoDal
    {

    }
}
