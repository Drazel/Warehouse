using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Data.Result;
using Warehouse.ServiceClient.WarehouseService;

namespace Warehouse.ServiceClient.Clients
{
    public static class OrderService
    {
        public static List<OutProductList> GetOutProductList()
        {
            return ServiceManager.Call<OrderClient, List<OutProductList>>(c => c.GetOutProductList().ToList());
        }

    }
}
