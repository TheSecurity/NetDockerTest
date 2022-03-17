using DocketTutorialServices.Models;
using MongoDB.Driver;

namespace DocketTutorialServices.Storage
{
    public class MongoUserData
    {
        private readonly IMongoCollection<UserModel> _users;

        public MongoUserData(IDbConnection db)
        {
            _users = db.UserCollection;
        }

        public async Task<IEnumerable<UserModel>> GetUsersAsync()
        {
            var result = await _users.FindAsync(_ => true);
            return result.ToList();
        }

        public async Task InsertUsersAsync(IEnumerable<UserModel> users)
        {
            await _users.InsertManyAsync(users);
        }
    }
}
