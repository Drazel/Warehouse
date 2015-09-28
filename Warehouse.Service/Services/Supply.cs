using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Warehouse.Data.Helper;
using Warehouse.Data.Repository;
using Warehouse.Data.Result;
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

        public List<SupplyItem> GetNewSupplys()
        {
            var result = new List<SupplyItem>();
            var supplys = supplyRepository.GetNewSupply();
            supplys.ForEach(x=>result.Add(ObjectMapper.Supply(x)));
            return result;
        }

        public List<SupplyItem> GetSupplys()
        {
            var result = new List<SupplyItem>();
            var supplys = supplyRepository.GetItemsList().ToList();
            supplys.ForEach(x => result.Add(ObjectMapper.Supply(x)));
            return result;
        }

        public SupplyItem GetSupplyBySupplyNumber(string supplyNumber)
        {
            var supply = supplyRepository.GetSupplyBySupplyNumber(supplyNumber);
            return ObjectMapper.Supply(supply);
        }
    }
}