namespace DocketTutorialServices.Services
{
    public class MainService
    {
        private readonly StorageService _storageService;

        public MainService(StorageService storageService)
        {
            _storageService = storageService;
        }

        public async Task RunAsync()
        {
            await DatabaseOperationAsync();
            await GenerateImageAsync();
        }

        private async Task GenerateImageAsync()
        {

        }

        private async Task DatabaseOperationAsync()
        {
            await _storageService.InsertDataAsync();
            await _storageService.GetDataAsync();
        }

    }
}
