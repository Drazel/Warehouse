using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using Warehouse.Data.Enum;

namespace Warehouse.Data.Result
{
    public class SupplyItem
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
        public List<Position> Positions { get; set; }

        public SupplyItem()
        {
            Positions=new List<Position>();
        }
    }
}
