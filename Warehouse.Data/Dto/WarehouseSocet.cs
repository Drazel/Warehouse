using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using Warehouse.Data.Attribute;

namespace Warehouse.Data.Dto
{
  [BsonCollection("WarehouseSocet")]  
    public class WarehouseSocet
    {
        #region Properties

        public ObjectId Id { get; set; }

        [BsonElementAttribute("Row")]
        public int RowBookstand { get; set; }

        [BsonElementAttribute("Shelf")]
        public int ShelfBookstand { get; set; }

        [BsonElementAttribute("SocetNumber")]
        public int SocetNumber { get; set; }

        [BsonElementAttribute("SocetBarcode")]
        public string SocetBarcode { get { return string.Format("{0}#{1}#{2}", RowBookstand, ShelfBookstand, SocetNumber); } }

        [BsonElementAttribute("Width")]
        public int Width { get; set; }

        [BsonElementAttribute("Height")]
        public int Height { get; set; }

        [BsonElementAttribute("Length")]
        public int Length { get; set; }

        [BsonElementAttribute("MaxWeight")]
        public double MaxWeight { get; set; }

        [BsonElementAttribute("UseWeight")]
        public double UseWeight { get; set; }

        [BsonElementAttribute("UseVolume")]
        public int UseVolume { get; set; }

        [BsonElementAttribute("Products")]
        public IList<MongoDBRef> Products { get; private set; }

        #endregion

        #region Constructors

        public WarehouseSocet()
        {
            Products = new List<MongoDBRef>();
        }

        #endregion

        #region Methods

        public void AddProductToSocet(Product product)
        {
            var refDb = new MongoDBRef("Product", product.Id);
            UseVolume += product.Volume;
            UseWeight += product.Weight;
            Products.Add(refDb);
        }

        #endregion
    }
}