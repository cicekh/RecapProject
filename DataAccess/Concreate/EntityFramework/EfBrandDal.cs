using DataAccess.Abstract;
using Entities.Concreate;
using Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Linq;


namespace DataAccess.Concreate.EntityFramework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand,ReCapContext>, IBrandDal
    {
        //Artık bunlar EfEntityRepositoryBase'deki IEntitiyRepository den gelecek artık.
        //public void Add(Brand entity)
        //{
        //    using (ReCapContext context = new ReCapContext())
        //    {
        //        var addedBrand = context.Entry(entity);
        //        addedBrand.State = EntityState.Added;
        //        context.SaveChanges();
        //    }
        //}

        //public void Delete(Brand entity)
        //{
        //    using (ReCapContext context = new ReCapContext())
        //    {
        //        var deletedBrand = context.Entry(entity);
        //        deletedBrand.State = EntityState.Deleted;
        //        context.SaveChanges();
        //    }
        //}

        //public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        //{
        //    using (ReCapContext context = new ReCapContext())
        //    {
        //        return filter == null ? context.Set<Brand>().ToList() : context.Set<Brand>().Where(filter).ToList();
        //    }
        //}

        //public Brand GetById(Expression<Func<Brand, bool>> filter)
        //{
        //    using (ReCapContext context = new ReCapContext())
        //    {
        //        return context.Set<Brand>().SingleOrDefault(filter);
        //    }
        //}

        //public void Update(Brand entity)
        //{
        //    using (ReCapContext context = new ReCapContext())
        //    {
        //        var updatedBrand = context.Entry(entity);
        //        updatedBrand.State = EntityState.Modified;
        //        context.SaveChanges();
        //    }
        //}
    }
}
