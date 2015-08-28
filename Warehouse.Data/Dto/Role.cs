using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Warehouse.Data.Attribute;

namespace Warehouse.Data.Dto
{
    [BsonCollection("Role")]
    public class Role
    {
        #region Properties

        public ObjectId Id { get; set; }

        [BsonElementAttribute("Name")]
        public string Name { get; set; }

        #endregion
    }
}