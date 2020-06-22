using Demo.Northwind.Business.Abstract;
using Demo.Nothwind.DataAccess.Abstract;
using Demo.Nothwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Northwind.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
