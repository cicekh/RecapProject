using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface IBrandService
    {
        void Add(Brand brand);
        void Update(Brand brand);
        void Delete(Brand brand);

        List<Brand> GetlAll();

        Brand GetById(int Id);

    }
}
