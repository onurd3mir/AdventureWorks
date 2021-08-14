namespace Business.Abstract
{
    public interface IMyAggregateService
    {
       IProductService ProductService { get; }
       ISalesService SalesService { get; }
    }
}
