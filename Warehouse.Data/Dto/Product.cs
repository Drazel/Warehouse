using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Warehouse.Data.Dto
{
    public class Product
    {
        #region Properties

        public ObjectId Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("Ean")]
        public string Ean { get; set; }

        [BsonElement("Width")]
        public int Width { get; set; }

        [BsonElement("Height")]
        public int Height { get; set; }

        [BsonElement("Length")]
        public int Length { get; set; }

        [BsonElement("Weight")]
        public int Weight { get; set; }

        public int Volume
        {
            get { return Width*Height*Length; }
        }

        #endregion
    }
}