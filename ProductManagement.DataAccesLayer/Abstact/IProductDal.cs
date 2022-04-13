using EntityLayer.Concrete;
using EntityLayer.DTO;
using ProductManagement.DataAccesLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.DataAccesLayer.Abstact
{
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductsWithCategoryDTO> GetProductByCategory(int id);
    }
}
