using EntityLayer.Concrete;
using EntityLayer.DTO;
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
    public class ProductRepository : EfEntityRepositoryBase<Product, MarsisDbContext>, IProductDal
    {
        public List<ProductsWithCategoryDTO> GetProductByCategory(int id)
        {
            using (MarsisDbContext context=new MarsisDbContext())
            {
                var values = (from p in context.Products
                              join c in context.Categories
                              on p.CategoryId equals c.ID
                              where c.ID == id && p.isActive == true
                              select new ProductsWithCategoryDTO
                              {
                                  ProductId=p.ID,
                                  ProductName = p.ProductName,
                                  CategoryName=c.CategoryName,
                                  UnitPrice = p.UnitPrice,
                                  Stock = p.Stock,
                                  CategoryId=id,                                  
                                  ProductCode = p.ProductCode,
                                  isActive=p.isActive

                              }).ToList();
                return values;
               
               
            }
        }
    }
}
