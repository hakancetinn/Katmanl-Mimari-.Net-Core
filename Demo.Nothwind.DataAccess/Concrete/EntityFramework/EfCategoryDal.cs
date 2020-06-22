using Demo.Core.DataAccess.EntityFramework;
using Demo.Nothwind.DataAccess.Abstract;
using Demo.Nothwind.Entities.Concrete;

namespace Demo.Nothwind.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
    }
}
