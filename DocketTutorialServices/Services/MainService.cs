namespace DocketTutorialServices.Services
{
    public class MainService
    {
        private readonly StorageService _storageService;
        private readonly ImageService _imageService;

        public MainService(StorageService storageService, ImageService imageService)
        {
            _storageService = storageService;
            _imageService = imageService;
        }

        public async Task RunAsync()
        {
            await DatabaseOperationAsync();
            await GenerateImageAsync();
        }

        private async Task GenerateImageAsync()
        {
            await _imageService.GenerateImageAsync();
        }

        private async Task DatabaseOperationAsync()
        {
            await _storageService.InsertDataAsync();
            await _storageService.GetDataAsync();
        }

    }
}
