using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class SalesManager : ISalesService
    {
        private ISalesDal _salesDal;

        public SalesManager(ISalesDal salesDal)
        {
            _salesDal = salesDal;
        }

        public IDataResult<List<SalesOrderHeader>> GetSalesQuery(int page = 1)
        {
            return new SuccessDataResult<List<SalesOrderHeader>>(_salesDal.GetSalesQuery(page));
        }
    }
}
