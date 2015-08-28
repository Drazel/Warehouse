using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Warehouse.Data.Dto
{
    public class User
    {
        #region Properties

        public ObjectId Id { get; set; }

        [BsonElement("FirstName")]
        public string FirstName { get; set; }

        [BsonElement("LastName")]
        public string LastName { get; set; }

        [BsonElement("Login")]
        public string Login { get; set; }

        [BsonElement("Pasword")]
        public string Pasword { get; set; }

        public Role Roles { get; set; }

        #endregion
    }
}