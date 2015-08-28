using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Warehouse.Data.Repository;
using Warehouse.Service.Contracts;

namespace Warehouse.Service
{
    public partial class Service : IWarehouseSocet
    {
        private static WarehouseSocetRepository warehouseSocetRepository = new WarehouseSocetRepository();


        public bool AddWarehouseSocet(Data.Dto.WarehouseSocet socet)
        {
            return warehouseSocetRepository.Add(socet);
        }

        public bool UpdateWarehouseSocet(Data.Dto.WarehouseSocet socet)
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
    }
}