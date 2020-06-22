using Demo.Nothwind.Entities.Concrete;
using System.Collections.Generic;

namespace Demo.Northwind.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
