using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Warehouse.Data.Attribute;

namespace Warehouse.Data.Dto
{
    [BsonCollection("User")]
    public class User
    {
        #region Properties

        public ObjectId Id { get; set; }

        [BsonElementAttribute("FirstName")]
        public string FirstName { get; set; }

        [BsonElementAttribute("LastName")]
        public string LastName { get; set; }

        [BsonElementAttribute("Login")]
        public string Login { get; set; }

        [BsonElementAttribute("Pasword")]
        public string Pasword { get; set; }

        public Role Roles { get; set; }

        #endregion
    }
}