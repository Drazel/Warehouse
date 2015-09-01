using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Warehouse.Data.Dto;
using Warehouse.Data.Repository;
using Warehouse.Data.Result;
using Warehouse.Service.Contracts;

namespace Warehouse.Service
{
    public partial class Service : ISocetProducts
    {
        private static SocetProductsRepository socetProductRepository = new SocetProductsRepository();

        public BoolResult AddProductToSocet(Data.Dto.Product product, Data.Dto.WarehouseSocet socet)
        {
            var result = new BoolResult();
            var socetProducts = new SocetProducts(product, socet);
            result = warehouseSocetRepository.UpdateUseVolumeAndWeight(socet.Id, product.Weight, product.Volume);
            if (result.Succes)
            {
                result = socetProductRepository.Add(socetProducts);
            }
            return result;
        }

        public BoolResult AddProductIdToSocetId(string productId, string socetId)
        {
            var result = new BoolResult();
            var socetProducts = new SocetProducts(productId, socetId);
            var product = productRepository.GetById(productId);
            result = warehouseSocetRepository.UpdateUseVolumeAndWeight(socetId, product.Weight, product.Volume);
            if (result.Succes)
            {
                result = socetProductRepository.Add(socetProducts);
            }
            return result;
        }

        public BoolResult AddManyProductToSocet(Data.Dto.Product product, Data.Dto.WarehouseSocet socet, int count)
        {
            var result = new BoolResult();
            var list = new List<SocetProducts>();
            for (int i = 0; i < count; i++)
            {
                list.Add(new SocetProducts(product, socet));
            }

            result = warehouseSocetRepository.UpdateUseVolumeAndWeight(socet.Id, product.Weight*count, product.Volume*count);
            if (result.Succes)
            {
                result = socetProductRepository.Add(list);
            }
            return result;
        }

        public BoolResult AddManyProductIdToSocetId(string productId, string socetId, int count)
        {
            var result = new BoolResult();
            var list = new List<SocetProducts>();
            for (int i = 0; i < count; i++)
            {
                list.Add(new SocetProducts(productId, socetId));
            }
            var product = productRepository.GetById(productId);
            result = warehouseSocetRepository.UpdateUseVolumeAndWeight(socetId, product.Weight * count, product.Volume * count);
            if (result.Succes)
            {
                result = socetProductRepository.Add(list);
            }
            return result;
        }

        public BoolResult GetProductFromSocet(Data.Dto.Product product, Data.Dto.WarehouseSocet socet)
        {
            throw new NotImplementedException();
        }

        public BoolResult GetManyProductFromSocet(Data.Dto.Product product, Data.Dto.WarehouseSocet socet, int count)
        {
            throw new NotImplementedException();
        }
    }
}