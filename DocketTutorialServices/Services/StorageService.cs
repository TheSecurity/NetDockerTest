using DocketTutorialServices.Models;
using DocketTutorialServices.Storage;

namespace DocketTutorialServices.Services
{
    public class StorageService
    {
        private readonly MongoUserData _userData;

        public StorageService(MongoUserData userData)
        {
            _userData = userData;
        }

        public async Task InsertDataAsync()
        {
            var users = new List<UserModel>()
            {
                new UserModel() { Name = "Abcdef" },
                new UserModel() { Name = "Ghijkl" },
                new UserModel() { Name = "Mnopqr" },
            };

           await _userData.InsertUsersAsync(users);
        }

        public async Task GetDataAsync()
        {
            var result = await _userData.GetUsersAsync();
        }
    }
}
