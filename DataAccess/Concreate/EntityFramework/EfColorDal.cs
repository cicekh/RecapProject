﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concreate;

namespace DataAccess.Concreate.EntityFramework
{
    public class EfColorDal : EfEntityRepositoryBase<Color,ReCapContext>, IColorDal
    {
        //public void Add(Color entity)
        //{
        //    using (ReCapContext context = new ReCapContext())
        //    {
        //        var addedColor = context.Entry(entity);
        //        addedColor.State = EntityState.Added;
        //        context.SaveChanges();
        //    }
        //}

        //public void Delete(Color entity)
        //{
        //    using (ReCapContext context = new ReCapContext())
        //    {
        //        var deletedColor = context.Entry(entity);
        //        deletedColor.State = EntityState.Deleted;
        //        context.SaveChanges();
        //    }
        //}

        //public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        //{
        //    using (ReCapContext context = new ReCapContext())
        //    {
        //        return filter == null ? context.Set<Color>().ToList() : context.Set<Color>().Where(filter).ToList();

        //    }
        //}

        //public Color GetById(Expression<Func<Color, bool>> filter)
        //{
        //    using (ReCapContext context = new ReCapContext())
        //    {
        //        return  context.Set<Color>().SingleOrDefault(filter);

        //    }
        //}

        //public void Update(Color entity)
        //{
        //    using (ReCapContext context = new ReCapContext())
        //    {
        //        var updatedColor = context.Entry(entity);
        //        updatedColor.State = EntityState.Modified;
        //        context.SaveChanges();
        //    }
        //}
    }
}
