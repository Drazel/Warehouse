using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Warehouse.Data.Dto
{
    public class WarehouseSocet
    {
        public ObjectId Id { get; set; }

        [BsonElement("Row")]
        public int RowBookstand { get; set; }

        [BsonElement("Shelf")]
        public int ShelfBookstand { get; set; }

        [BsonElement("SocetNumber")]
        public int SocetNumber { get; set; }

        [BsonElement("Width")]
        public int Width { get; set; }

        [BsonElement("Height")]
        public int Height { get; set; }

        [BsonElement("Length")]
        public int Length { get; set; }

        [BsonElement("MaxWeight")]
        public int MaxWeight { get; set; }

        [BsonElement("UseWeight")]
        public int UseWeight { get; set; }

        [BsonElement("UseVolume")]
        public int UseVolume { get; set; }
    }
}
