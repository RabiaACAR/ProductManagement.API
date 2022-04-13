using EntityLayer.Concrete;
using ProductManagement.DataAccesLayer.Abstact;
using ProductManagement.DataAccesLayer.Context;
using ProductManagement.DataAccesLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.DataAccesLayer.Concrete
{
    public class CategoryRepository:EfEntityRepositoryBase<Category, MarsisDbContext>, ICategoryDal
    {
    }
}
