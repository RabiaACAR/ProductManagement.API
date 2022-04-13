using EntityLayer.Concrete;
using ProductManagement.DataAccesLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.DataAccesLayer.Abstact
{
    public interface ICategoryDal:IEntityRepository<Category>
    {
    }
}
