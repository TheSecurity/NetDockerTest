using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DocketTutorialServices.Models
{
    public class UserModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = null!;

        public string Name { get; set; } = null!;
    }
}
