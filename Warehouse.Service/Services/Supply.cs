using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Warehouse.Data.Repository;
using Warehouse.Service.Contracts;

namespace Warehouse.Service
{
    public partial class Service : ISupply
    {
        private static SupplyRepository supplyRepository = new SupplyRepository();


        public Data.Result.BoolResult AddSupply(Data.Dto.Supply supply)
        {
            return supplyRepository.Add(supply);
        }
    }
}