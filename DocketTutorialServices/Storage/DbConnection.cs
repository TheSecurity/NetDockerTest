using DocketTutorialServices.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace DocketTutorialServices.Storage
{
    public class DbConnection : IDbConnection
    {
        private readonly IConfiguration _config;
        private readonly IMongoDatabase _db;
        private readonly string _connectionId = "MongoDB";
        public string DbName { get; private set; }
        public string UserCollectionName { get; private set; } = "users";

        public MongoClient Client { get; private set; }
        public IMongoCollection<UserModel> UserCollection { get; private set; }


        public DbConnection(IConfiguration config)
        {
            _config = config;
            Client = new MongoClient(_config.GetConnectionString(_connectionId));
            DbName = _config["DatabaseName"];
            _db = Client.GetDatabase(DbName);

            UserCollection = _db.GetCollection<UserModel>(UserCollectionName);
        }
    }
}
