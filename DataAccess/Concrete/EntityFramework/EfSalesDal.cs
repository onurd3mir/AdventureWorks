using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfSalesDal : EntityFrameworkRepositoryBase<SalesOrderHeader, AdventureWorksContext>, ISalesDal
    {
        public List<SalesOrderHeader> GetSalesQuery(int page = 1)
        {
            using (var context = new AdventureWorksContext())
            {
                int take = 500;

                var result = context.SalesOrderHeader
                    .Include("Customer")
                    .Include("Customer.Person")
                    .Include("Address")
                    .Include("Address1")
                    .Include("ShipMethod")
                    .OrderByDescending(s => s.ShipDate)
                    .Skip((page - 1) * take)
                    .Take(take)
                    .ToList();

                return result;
            }
        }
    }
}
