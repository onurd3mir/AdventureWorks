using Autofac;
using Autofac.Extras.AggregateService;
using AutoMapper;
using Business.Abstract;
using Business.Concrete;
using Business.Mapper.AutoMapper;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAggregateService<IMyAggregateService>();

            builder.RegisterType<ProductManager>().As<IProductService>();
            builder.RegisterType<EfProductDal>().As<IProductDal>();

            builder.RegisterType<SalesManager>().As<ISalesService>();
            builder.RegisterType<EfSalesDal>().As<ISalesDal>();

            var mappingConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapperProfiles());
            });
            IMapper mapper = mappingConfig.CreateMapper();

            builder.RegisterInstance(mapper);
        }
    }
}
