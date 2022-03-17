using DocketTutorialServices.Models;
using MongoDB.Driver;

namespace DocketTutorialServices.Storage
{
    public interface IDbConnection
    {
        MongoClient Client { get; }
        string DbName { get; }
        IMongoCollection<UserModel> UserCollection { get; }
        string UserCollectionName { get; }
    }
}