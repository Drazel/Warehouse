using System.Collections.Generic;
using AutoMapper;
using MongoDB.Bson;
using Warehouse.Data.Dto;
using Warehouse.Data.Result;
using Warehouse.Models.Base;
using Warehouse.Models.Package;
using Warehouse.Models.Product;
using Warehouse.Models.ProductList;
using Warehouse.Models.Supply;
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

            Mapper.CreateMap<BoolResult, BaseModel>();
            Mapper.CreateMap<BaseModel, BoolResult>();

            Mapper.CreateMap<ProductSumModel, ProductSum>();
            Mapper.CreateMap<ProductSum, ProductSumModel>();

            Mapper.CreateMap<OutProductListModel, OutProductList>()
                .ForMember(dest => dest.Products, opt => opt.MapFrom(src => Mapper.Map<List<ProductSumModel>>( src.Products)));
            Mapper.CreateMap<OutProductList, OutProductListModel>()
                .ForMember(dest => dest.Products, opt => opt.MapFrom(src => Mapper.Map<List<ProductSum>>(src.Products)));

            Mapper.CreateMap<Position, PositionModel>()
               .ForMember(dest => dest.Product, opt => opt.MapFrom(src => Mapper.Map<ProductModel>(src.Product)));

            Mapper.CreateMap<SupplyItem, SupplyModel>()
               .ForMember(dest => dest.Positions, opt => opt.MapFrom(src => Mapper.Map<List<PositionModel>>(src.Positions)));
        }
    }
}