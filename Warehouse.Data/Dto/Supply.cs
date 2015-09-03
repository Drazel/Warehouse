using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Warehouse.Data.Attribute;
using Warehouse.Data.Enum;

namespace Warehouse.Data.Dto
{
    [BsonCollection("Supply")]
    public class Supply
    {
        public ObjectId Id { get; set; }

        [BsonElementAttribute("SupplyNumber")]
        public string SupplyNumber { get; set; }

        [BsonElementAttribute("SupplierId")]
        public int SupplierId { get; set; }

        [BsonElementAttribute("CreateDate")]
        public DateTime CreateDate { get; set; }

        [BsonElementAttribute("Street")]
        public string Street { get; set; }

        [BsonElementAttribute("HouseNumber")]
        public string HouseNumber { get; set; }

        [BsonElementAttribute("FlatNumber")]
        public string FlatNumber { get; set; }

        [BsonElementAttribute("PostalCode")]
        public string PostalCode { get; set; }

        [BsonElementAttribute("City")]
        public string City { get; set; }

        [BsonElementAttribute("CountryCode")]
        public string CountryCode { get; set; }

        [BsonElementAttribute("SupplyStatus")]
        public eSupplyStatus SupplyStatus { get; set; }

        [BsonElementAttribute("Positions")]
        public IList<SupplyPosition> Positions { get; set; }

        public Supply()
        {
            Positions = new List<SupplyPosition>();
        }
    }
}
