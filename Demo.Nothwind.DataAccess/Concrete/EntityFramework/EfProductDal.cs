using Demo.Core.DataAccess.EntityFramework;
using Demo.Nothwind.DataAccess.Abstract;
using Demo.Nothwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Nothwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {

    }
}
