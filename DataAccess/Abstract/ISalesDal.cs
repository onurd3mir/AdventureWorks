using Entities.Concrete;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface ISalesDal : IEntityFrameworkRepository<SalesOrderHeader>
    {
        List<SalesOrderHeader> GetSalesQuery(int page = 1);
    }
}
