using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concreate.EntityFramework
{
    public class EfPhotoDal: EfEntityRepositoryBase<Photo,ReCapContext>,IPhotoDal
    {

    }
}
