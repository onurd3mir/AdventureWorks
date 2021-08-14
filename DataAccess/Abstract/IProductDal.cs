using Entities.Concrete;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityFrameworkRepository<Product>
    {
        List<Product> GetProductQuery();
        Product GetProductById(int id);
    }
}
