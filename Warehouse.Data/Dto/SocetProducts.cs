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
    [BsonCollection("SocetProducts")]  
    public class SocetProducts
    {
        public ObjectId Id { get; set; }

        [BsonElementAttribute("WarehouseSocetId")]
        public MongoDBRef WarehouseSocetId { get; set; }

        [BsonElementAttribute("ProductId")]
        public MongoDBRef ProductId { get; set; }

        [BsonElementAttribute("TimeStamp")]
        public DateTime TimeStamp { get; set; }

        public SocetProducts()
        {
            this.TimeStamp = DateTime.Now;
        }

        public SocetProducts(Product product, WarehouseSocet warehouseSocet)
        {
            WarehouseSocetId = new MongoDBRef("WarehouseSocet", warehouseSocet.Id);
            ProductId = new MongoDBRef("Product", product.Id);
            this.TimeStamp = DateTime.Now;
        }

        public SocetProducts(string productId, string warehouseSocetId)
        {
            WarehouseSocetId = new MongoDBRef("WarehouseSocet", warehouseSocetId);
            ProductId = new MongoDBRef("Product", productId);
            this.TimeStamp = DateTime.Now;
        }
    }
}
