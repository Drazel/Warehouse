using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Warehouse.Data.Enum;
using Warehouse.Models.Base;
using Warehouse.Models.Product;
using WarehouseResource;

namespace Warehouse.Models.Supply
{
    public class SupplyModel : BaseModel
    {
        public string Id { get; set; }
        public string SupplyNumber { get; set; }
        public int SupplierId { get; set; }
        public DateTime CreateDate { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string FlatNumber { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string CountryCode { get; set; }
        public eSupplyStatus SupplyStatus { get; set; }

        public string SupplyStatusString
        {
            get
            {
                var result = string.Empty;
                switch (SupplyStatus)
                {
                    case eSupplyStatus.New:
                        result = ResSupply.StatusNew;
                        break;
                    case eSupplyStatus.Provided:
                        result = ResSupply.StatusProvided;
                        break;
                    case eSupplyStatus.Adopted:
                        result = ResSupply.StatusAdopted;
                        break;
                    default:
                        result = string.Empty;
                        break;
                }
                return result;
            }
        }

        public List<PositionModel> Positions { get; set; }
       
    }
}