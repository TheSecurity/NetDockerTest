using Microsoft.Extensions.Configuration;
using PuppeteerSharp;

namespace DocketTutorialServices.Services
{
    public class ImageService
    {
        private const string BrowserWSKey = "BrowserWS";

        private readonly IConfiguration _config;

        public ImageService(IConfiguration config)
        {
            _config = config;
        }

        public async Task GenerateImageAsync()
        {
            var browser = await Puppeteer.ConnectAsync(new ConnectOptions
            {
                BrowserWSEndpoint = _config.GetSection(BrowserWSKey).Value
            });
            var page = await browser.NewPageAsync();
            await page.GoToAsync("https://www.google.com");
            await page.ScreenshotAsync("screenshot.png");
        }
    }
}
