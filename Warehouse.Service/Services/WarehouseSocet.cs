using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Warehouse.Data.Repository;
using Warehouse.Data.Result;
using Warehouse.Service.Contracts;

namespace Warehouse.Service
{
    public partial class Service : IWarehouseSocet
    {
        private static WarehouseSocetRepository warehouseSocetRepository = new WarehouseSocetRepository();

        public BoolResult AddWarehouseSocet(Data.Dto.WarehouseSocet socet)
        {
            return warehouseSocetRepository.Add(socet);
        }

        public BoolResult UpdateWarehouseSocet(Data.Dto.WarehouseSocet socet)
        {
            return warehouseSocetRepository.Update(socet);
        }

        public IEnumerable<Data.Dto.WarehouseSocet> GetWarehouseSocets()
        {
            return warehouseSocetRepository.GetItemsList();
        }

        public Data.Dto.WarehouseSocet GetWarehouseSocet(string socetId)
        {
            return warehouseSocetRepository.GetById(socetId);
        }

        public string GetSocetByBarcode(string barcode)
        {
            return warehouseSocetRepository.GetSocetByBarcode(barcode);
        }
    
    }
}