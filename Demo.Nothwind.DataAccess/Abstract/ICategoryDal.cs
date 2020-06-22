using Demo.Core.DataAccess;
using Demo.Nothwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Nothwind.DataAccess.Abstract
{
    public interface ICategoryDal:IEntityRepository<Category>
    {
    }
}
