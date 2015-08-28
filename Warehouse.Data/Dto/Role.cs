using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Warehouse.Data.Dto
{
    public class Role
    {
        #region Properties

        public ObjectId Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        #endregion
    }
}