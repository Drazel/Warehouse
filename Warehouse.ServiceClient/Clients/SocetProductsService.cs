using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Warehouse.Data.Result;
using Warehouse.ServiceClient.WarehouseService;

namespace Warehouse.ServiceClient.Clients
{
    public static class SocetProductsService
    {
        public static BoolResult AddProductToSocet(Data.Dto.Product product, Data.Dto.WarehouseSocet socet)
        {
            return ServiceManager.Call<SocetProductsClient, BoolResult>(c => c.AddProductToSocet(product, socet));
        }

        public static BoolResult AddProductIdToSocetId(string productId, string socetId)
        {
            return ServiceManager.Call<SocetProductsClient, BoolResult>(c => c.AddProductIdToSocetId(productId, socetId));
        }

        public static BoolResult AddProductToSocet(Data.Dto.Product product, Data.Dto.WarehouseSocet socet, int count)
        {
            return ServiceManager.Call<SocetProductsClient, BoolResult>(c => c.AddManyProductToSocet(product, socet, count));
        }

        public static BoolResult AddProductIdToSocetId(string productId, string socetId, int count)
        {
            return ServiceManager.Call<SocetProductsClient, BoolResult>(c => c.AddManyProductIdToSocetId(productId, socetId, count));
        }

        public static BoolResult GetProductFromSocet(Data.Dto.Product product, Data.Dto.WarehouseSocet socet)
        {
            return ServiceManager.Call<SocetProductsClient, BoolResult>(c => c.GetProductFromSocet(product, socet));
        }

        public static BoolResult GetManyProductTFromSocet(Data.Dto.Product product, Data.Dto.WarehouseSocet socet, int count)
        {
            return ServiceManager.Call<SocetProductsClient, BoolResult>(c => c.GetManyProductFromSocet(product, socet, count));
        }

    }
}
