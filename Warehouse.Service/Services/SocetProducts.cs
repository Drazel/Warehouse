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
            var socetProducts = new SocetProducts(product, socet);

            return socetProductRepository.Add(socetProducts);
        }

        public BoolResult AddManyProductToSocet(Data.Dto.Product product, Data.Dto.WarehouseSocet socet, int count)
        {
            var list = new List<SocetProducts>();
            for (int i = 0; i < count; i++)
            {
                list.Add(new SocetProducts(product, socet));
            }

            return socetProductRepository.Add(list);
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