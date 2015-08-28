using AutoMapper;
using MongoDB.Bson;
using Warehouse.Data.Dto;
using Warehouse.Models.Package;
using Warehouse.Models.Product;
using Warehouse.Models.WarehouseSocet;

namespace Warehouse
{
    public class AutoMapperConfiguration
    {
        public static void Initialize()
        {
            Mapper.CreateMap<Product, ProductModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.ToString()));
            Mapper.CreateMap<ProductModel, Product>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id != null ? ObjectId.Parse(src.Id) : new ObjectId()));

            Mapper.CreateMap<WarehouseSocet, WarehouseSocetModel>()
               .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.ToString()));
            Mapper.CreateMap<WarehouseSocetModel, WarehouseSocet>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id != null ? ObjectId.Parse(src.Id) : new ObjectId()));

            Mapper.CreateMap<Package, PackageModel>()
               .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.ToString()));
            Mapper.CreateMap<PackageModel, Package>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id != null ? ObjectId.Parse(src.Id) : new ObjectId()));
        }
    }
}