using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using Warehouse.Data.Attribute;

namespace Warehouse.Data.Dto
{
    [BsonCollection("SupplyPosition")]
    public class SupplyPosition
    {
        [BsonElementAttribute("Lp")]
        public int Lp { get; set; }

        [BsonElementAttribute("ProductId")]
        public MongoDBRef ProductId { get { return new MongoDBRef("Product", ProductIdString); } }

        [BsonElementAttribute("Count")]
        public int Count { get; set; }

        public string ProductIdString { get; set; }

        public SupplyPosition(){ }

        public SupplyPosition(int lp, string productId, int count)
        {
            Lp = lp;
            Count = count;
            ProductIdString = productId;
        }
    }
}
