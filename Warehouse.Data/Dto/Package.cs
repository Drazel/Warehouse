using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Warehouse.Data.Dto
{
    public class Package
    {
        public ObjectId Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("Width")]
        public int Width { get; set; }

        [BsonElement("Height")]
        public int Height { get; set; }

        [BsonElement("Length")]
        public int Length { get; set; }

        public int Volume { get { return Width * Height * Length; } }
    }
}
