using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        //interface methodları default olarak public'tir
        List<product> GetAll();
        void Add(product product);
        void Update(product product);
        void Delete(product product);

        List<product> GetAllByCategory(int categoryId);
    }
}
