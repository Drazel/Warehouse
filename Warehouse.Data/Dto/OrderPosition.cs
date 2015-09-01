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
    [BsonCollection("OrderPosition")]
    public class OrderPosition
    {
        public ObjectId Id { get; set; }

        [BsonElementAttribute("Lp")]
        public int Lp { get; set; }

        [BsonElementAttribute("ProductId")]
        public MongoDBRef ProductId { get; set; }

        [BsonElementAttribute("Count")]
        public int Count { get; set; }
   
    }
}
