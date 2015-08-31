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
    public class SocetProductsService
    {
        public BoolResult AddProductToSocet(Data.Dto.Product product, Data.Dto.WarehouseSocet socet)
        {
            return ServiceManager.Call<SocetProductsClient, BoolResult>(c => c.AddProductToSocet(product, socet));
        }

        public BoolResult AddProductToSocet(Data.Dto.Product product, Data.Dto.WarehouseSocet socet, int count)
        {
            return ServiceManager.Call<SocetProductsClient, BoolResult>(c => c.AddManyProductToSocet(product, socet, count));
        }

        public BoolResult GetProductFromSocet(Data.Dto.Product product, Data.Dto.WarehouseSocet socet)
        {
            return ServiceManager.Call<SocetProductsClient, BoolResult>(c => c.GetProductFromSocet(product, socet));
        }

        public BoolResult GetManyProductTFromSocet(Data.Dto.Product product, Data.Dto.WarehouseSocet socet, int count)
        {
            return ServiceManager.Call<SocetProductsClient, BoolResult>(c => c.GetManyProductFromSocet(product, socet, count));
        }

    }
}
