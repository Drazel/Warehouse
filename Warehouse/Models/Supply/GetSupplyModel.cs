using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Warehouse.Models.Supply
{
    public class GetSupplyModel
    {
        public string SupplyNumber { get; set; }

        public GetSupplyModel() { }

        public GetSupplyModel(string supplyNumber)
        {
            SupplyNumber = supplyNumber;
        }
    }
}