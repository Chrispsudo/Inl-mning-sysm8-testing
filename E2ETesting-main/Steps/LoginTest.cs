using TechTalk.SpecFlow;

namespace E2ETesting.Steps
{
    [Binding]
    class LoginTest : Base
    {
        [Given("I am on the login page")]
        public async Task GivenIAmOnTheLoginPage()
        {
            await _page.GotoAsync("http://localhost:5211/Account/Login");
        }

        [When(@"I enter ""(.*)"" as the username")]
        public async Task WhenIEnterAsTheName(string name)
        {
            await _page.FillAsync("input[name='Email']", name);
        }

        [When(@"I enter ""(.*)"" as the password")]
        public async Task WhenIEnterAsThePassword(string password)
        {
            await _page.FillAsync("input[name='Password']", password);
        }

        [Then(@"I click on the login button")]

        public async Task ThenIClickOnTheLoginButton()
        {
            await _page.ClickAsync("#Login");
        }
    }
}
