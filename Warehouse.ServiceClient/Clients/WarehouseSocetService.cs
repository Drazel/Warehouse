using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Data.Dto;
using Warehouse.Data.Result;
using Warehouse.ServiceClient.WarehouseService;

namespace Warehouse.ServiceClient.Clients
{
    public static class WarehouseSocetService
    {
        public static BoolResult AddWarehouseSocet(WarehouseSocet warehouseSocet)
        {
            return ServiceManager.Call<WarehouseSocetClient, BoolResult>(c => c.AddWarehouseSocet(warehouseSocet));
        }

        public static BoolResult UpdateWarehouseSocet(WarehouseSocet warehouseSocet)
        {
            return ServiceManager.Call<WarehouseSocetClient, BoolResult>(c => c.UpdateWarehouseSocet(warehouseSocet));
        }

        public static IEnumerable<WarehouseSocet> GetWarehouseSocets()
        {
            return ServiceManager.Call<WarehouseSocetClient, IEnumerable<WarehouseSocet>>(c => c.GetWarehouseSocets());
        }

        public static WarehouseSocet GetWarehouseSocet(string warehouseSocetId)
        {
            return ServiceManager.Call<WarehouseSocetClient, WarehouseSocet>(c => c.GetWarehouseSocet(warehouseSocetId));
        }

        public static WarehouseSocet GetSocetByBarcode(string barcode)
        {
            return ServiceManager.Call<WarehouseSocetClient, WarehouseSocet>(c => c.GetSocetByBarcode(barcode));
        }
    }
}
