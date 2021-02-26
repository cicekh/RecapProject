using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface IColorService
    {
        Color GetById(int Id);
        void Add(Color color);
        void Update(Color color);
        void Delete(Color color);
        List<Color> GetAll();
    }
}
