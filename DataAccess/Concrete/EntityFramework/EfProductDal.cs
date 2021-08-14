using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EntityFrameworkRepositoryBase<Product, AdventureWorksContext>, IProductDal
    {
        public Product GetProductById(int id)
        {
            using (var context = new AdventureWorksContext())
            {
                var result = context.Product
                    .Include("ProductSubcategory")
                    .Include("ProductSubcategory.ProductCategory")
                    .SingleOrDefault(p => p.ProductID == id);
                return result;
            }
        }

        public List<Product> GetProductQuery()
        {
            using (var context = new AdventureWorksContext())
            {
                var result = context.Product
                    .Include("ProductSubcategory")
                    .Include("ProductSubcategory.ProductCategory")
                    .ToList();
                return result;
            }
        }
    }
}
