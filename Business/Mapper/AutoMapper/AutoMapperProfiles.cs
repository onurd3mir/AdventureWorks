using AutoMapper;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Mapper.AutoMapper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Product, ProductDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ProductID))
                .ForMember(dest => dest.Number, opt => opt.MapFrom(src => src.ProductNumber))
                .ForMember(dest => dest.Stock, opt => opt.MapFrom(src => src.SafetyStockLevel))
                .ForMember(dest => dest.UnitPrice, opt => opt.MapFrom(src => src.ListPrice))
                .ForMember(dest => dest.SubCategoryName, opt => opt.MapFrom(src => src.ProductSubcategory.Name))
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.ProductSubcategory.ProductCategory.Name));


            CreateMap<SalesOrderHeader, SalesDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.SalesOrderID))
                .ForMember(dest => dest.OrderNumber, opt => opt.MapFrom(src => src.SalesOrderNumber))
                .ForMember(dest => dest.ApproveCode, opt => opt.MapFrom(src => src.CreditCardApprovalCode))
                .ForMember(dest => dest.ApproveCode, opt => opt.MapFrom(src => src.CreditCardApprovalCode))
                .ForMember(dest => dest.CustomerName, opt =>
                        opt.MapFrom(src => src.Customer.Person.FirstName + " " + src.Customer.Person.LastName))
                .ForMember(dest => dest.BillingAddress, opt => opt.MapFrom(src => src.Address.AddressLine1))
                .ForMember(dest => dest.BillingCity, opt => opt.MapFrom(src => src.Address.City))
                .ForMember(dest => dest.DeliveryAddress, opt => opt.MapFrom(src => src.Address1.AddressLine1))
                .ForMember(dest => dest.DeliveryCity, opt => opt.MapFrom(src => src.Address1.City))
                .ForMember(dest => dest.CargoName, opt => opt.MapFrom(src => src.ShipMethod.Name));

        }
    }
}