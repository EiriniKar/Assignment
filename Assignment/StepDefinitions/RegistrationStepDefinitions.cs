using System;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Assignment.StepDefinitions
{
    [Binding]
    public sealed class RegistrationStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private static IPage page;
        private ScenarioContext _scenarioContext;
        private static string username;
        private static string password="12345";


        public RegistrationStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given("User navigates to home page")]
        public async Task UserNavigatesToHomePage()
        {
            var playwright = await Playwright.CreateAsync();
            var browser =  await playwright.Firefox.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
                SlowMo = 50,
            });
            var context= await browser.NewContextAsync();
            page = await browser.NewPageAsync();

            _scenarioContext.Add("page",page);
            await page.GotoAsync("https://parabank.parasoft.com/parabank/register.htm");
            await page.ScreenshotAsync(new PageScreenshotOptions { Path = "screenshot.png" });
        }

        [Given("User navigates to registration page")]
        public async Task UserNavigatesToRegistrationPage()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Firefox.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
                SlowMo = 50,
            });
            var context = await browser.NewContextAsync();
            page = await browser.NewPageAsync();

            _scenarioContext.Add("page", page);
            await page.GotoAsync("https://parabank.parasoft.com/parabank/register.htm");
            await page.ScreenshotAsync(new PageScreenshotOptions { Path = "screenshot.png" });
        }

        [When("User logins with username (.*) and password (.*)")]
        public async Task UserLogins(string username, string password)
        {
            var page = (IPage)_scenarioContext["page"];
            await page.FillAsync("[name='username']", username);
            await page.FillAsync("[name='password']", password);
            await page.Keyboard.PressAsync("Enter");
        }

        [When("User registers with valid data (.*) (.*) (.*) (.*) (.*) (.*) (.*) (.*)")]
        public async Task UserRegisters(string firstName, string lastName, string address, string city, string state, string zipCode, string phone, string ssn)
        {
            username = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString();

            var page = (IPage)_scenarioContext["page"];
            await page.FillAsync("[name='customer.firstName']", firstName);
            await page.FillAsync("[name='customer.lastName']", lastName);
            await page.FillAsync("[name='customer.address.street']", address);
            await page.FillAsync("[name='customer.address.city']", city);
            await page.FillAsync("[name='customer.address.state']", state);
            await page.FillAsync("[name='customer.address.zipCode']", zipCode);
            await page.FillAsync("[name='customer.phoneNumber']", phone);
            await page.FillAsync("[name='customer.ssn']", ssn);

            await page.FillAsync("[name='customer.username']", username);
            await page.FillAsync("[name='customer.password']", password);
            await page.FillAsync("[name='repeatedPassword']", password);
        }

        [Given("User registers with username (.*) password (.*)")]
        public async Task UserRegistersWithUsername(string username, string password)
        {
            username = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString();

            var page = (IPage)_scenarioContext["page"];
            await page.FillAsync("[name='customer.firstName']", "loginTest");
            await page.FillAsync("[name='customer.lastName']", "loginTest");
            await page.FillAsync("[name='customer.address.street']", "loginTest");
            await page.FillAsync("[name='customer.address.city']", "loginTest");
            await page.FillAsync("[name='customer.address.state']", "loginTest");
            await page.FillAsync("[name='customer.address.zipCode']", "loginTest");
            await page.FillAsync("[name='customer.phoneNumber']", "loginTest");
            await page.FillAsync("[name='customer.ssn']", "loginTest");

            await page.FillAsync("[name='customer.username']", username);
            await page.FillAsync("[name='customer.password']", password);
            await page.FillAsync("[name='repeatedPassword']", password);

            await page.Keyboard.PressAsync("Enter");
        }

        [When("User registers with data (.*) (.*) (.*) (.*) (.*) (.*) (.*) (.*) and wrong confirm")]
        public async Task UserLoginsWrongConfirm(string firstName, string lastName, string address, string city, string state, string zipCode, string phone, string ssn)
        {
            username = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString();

            var page = (IPage)_scenarioContext["page"];
            await page.FillAsync("[name='customer.firstName']", firstName);
            await page.FillAsync("[name='customer.lastName']", lastName);
            await page.FillAsync("[name='customer.address.street']", address);
            await page.FillAsync("[name='customer.address.city']", city);
            await page.FillAsync("[name='customer.address.state']", state);
            await page.FillAsync("[name='customer.address.zipCode']", zipCode);
            await page.FillAsync("[name='customer.phoneNumber']", phone);
            await page.FillAsync("[name='customer.ssn']", ssn);
            await page.FillAsync("[name='customer.lastName']", lastName);

            await page.FillAsync("[name='customer.username']", username);
            await page.FillAsync("[name='customer.password']", password);
            await page.FillAsync("[name='repeatedPassword']", "wrong");
        }

        [When("User clicks on Register button")]
        public async Task WhenUserClicksRegisterButton()
        {
            var page = (IPage)_scenarioContext["page"];
            
            await page.ClickAsync("[value='Register']");
        }

        [When("User presses enter")]
        public async Task WhenUserPressesEnter()
        {
            var page = (IPage)_scenarioContext["page"];
            await page.Keyboard.PressAsync("Enter");
            await page.ScreenshotAsync(new PageScreenshotOptions { Path = "screenshot.png" });
        }

        [Given("User Signs Out")]
        public async Task WhenUserSignsOut()
        {
            var page = (IPage)_scenarioContext["page"];
            await page.ClickAsync("[href='/parabank/logout.htm']");
        }

        [Then("Account created successfully")]
        public async Task accountCreatedSuccessfully()
        {         
            var page = (IPage)_scenarioContext["page"];

            var welcomeTitle = await page.InnerTextAsync("h1.title");
            var expected = "Welcome " + username;

            Assert.AreEqual(expected, welcomeTitle);
        }

        [Then("Account isn't created and an error appears")]
        public async Task accountisntCreated()
        {
            var page = (IPage)_scenarioContext["page"];

            var welcomeTitle = await page.InnerTextAsync("h1.title");
            var expected = "Signing up is easy!";
            await page.ScreenshotAsync(new PageScreenshotOptions { Path = "screenshot.png" });

            Assert.AreEqual(expected, welcomeTitle);

            var error = await page.InnerTextAsync("[class='error']");

            Assert.IsTrue(error.Contains("is required"));
        }

        [Then("Account isn't created and password mismatch error appears")]
        public async Task accountisntCreatedPswMismatch()
        {
            var page = (IPage)_scenarioContext["page"];

            var welcomeTitle = await page.InnerTextAsync("h1.title");
            var expected = "Signing up is easy!";
            await page.ScreenshotAsync(new PageScreenshotOptions { Path = "screenshot.png" });

            Assert.AreEqual(expected, welcomeTitle);

            var error = await page.InnerTextAsync("[class='error']");

            Assert.IsTrue(error.Contains("Passwords did not match"));
        }

        [Then("Login fails")]
        public async Task loginFails()
        {
            var page = (IPage)_scenarioContext["page"];

            var welcomeTitle = await page.InnerTextAsync("h1.title");
            var expected = "Error!";
            await page.ScreenshotAsync(new PageScreenshotOptions { Path = "screenshot.png" });

            Assert.AreEqual(expected, welcomeTitle);
        }

        [Then("Login succeeds")]
        public async Task loginSucceeds()
        {
            var page = (IPage)_scenarioContext["page"];

            var welcomeTitle = await page.InnerTextAsync("h1.title");
            var expected = "Accounts Overview";
            await page.ScreenshotAsync(new PageScreenshotOptions { Path = "screenshot.png" });

            Assert.AreEqual(expected, welcomeTitle);

            var smallText = await page.InnerTextAsync("p.smallText");
            Assert.IsTrue(smallText.Contains("Welcome"));
        }
    }
}