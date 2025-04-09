using Microsoft.Playwright;
using TechTalk.SpecFlow;

namespace E2ETesting
{
    class Base
    {
        protected IPlaywright _playwright { get; private set; } = null!;
        protected IBrowser _browser { get; private set; } = null!;
        protected IBrowserContext _context { get; private set; } = null!;
        protected IPage _page { get; private set; } = null!;

        [BeforeScenario]
        public async Task Setup()
        {
            _playwright = await Playwright.CreateAsync();
            _browser = await _playwright.Chromium.LaunchAsync(new() { Headless = false, SlowMo = 1000 });
            _context = await _browser.NewContextAsync();
            _page = await _context.NewPageAsync();
        }

        [AfterScenario]
        public async Task Teardown()
        {
            await _browser.CloseAsync();
            _playwright.Dispose();
        }
    }
}
