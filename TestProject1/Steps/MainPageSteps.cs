using System.IO;
using System.Reflection;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using TestProject1.Pages;
using TestProject1.Pages.ExternalPages;

namespace TestProject1.Steps
{
    [Binding]
    [Scope(Feature = "MainPage")]

    public class MainPageSteps
    {
        private IWebDriver Driver { get; set; }
        private MainPage MainAppPage { get; set; }
        private GitHubProjectPage GitHubProjectPage { get; set; }

        [BeforeScenario]
        public void ScenarioSetup()
        {
            Driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            MainAppPage = new MainPage(Driver);
        }

        [Given(@"I have opened main page")]
        public void GivenIHaveOpenedMainPage()
        {
            MainAppPage.Open();
        }

        [Then(@"The title of main page is '(.*)'")]
        public void ThenTheTitleOfMainPageIs(string title)
        {
            Assert.AreEqual(title, MainAppPage.GetPageTitle(), "Title of a home page is wrong");
        }

        [Then(@"The header of main page is '(.*)'")]
        public void ThenTheHeaderOfMainPageIs(string header)
        {
            Assert.AreEqual(header, MainAppPage.MainHeader.Text, "Header of a home page is wrong");
        }

        [Given(@"I have scrolled to the down")]
        public void GivenIHaveScrolledToTheDown()
        {
            MainAppPage.ScrollToTheBottom();

        }

        [Then(@"The footer of the main page is '(.*)'")]
        public void ThenTheFooterOfTheMainPageIs(string footer)
        {
            Assert.AreEqual(footer, MainAppPage.MainFooter.Text, "Footer of a home page is wrong");
        }

        [Given(@"I have opened a home page")]
        public void GivenIHaveOpenedAHomePage()
        {
            MainAppPage.Open();
        }

        [Given(@"I have clicked on the image in the right top")]
        public void GivenIHaveClickedOnTheImageInTheRightTop()
        {
            GitHubProjectPage = MainAppPage.NavigateToGitHubProjectPage();
            //Assert.AreEqual(footer, MainAppPage.LinkFooter.Displayed, "The link in the footer of a home page is not working");
        }

        [Then(@"The image directs us to page '(.*)'")]
        public void ThenTheImageDirectsUsToPage(string gitHubProjectUrl)
        {
            Assert.AreEqual(gitHubProjectUrl, GitHubProjectPage.GetPageUrl(), "Url is incorrect.");
        }


        [AfterScenario]
        public void ScenarioTeardown()
        {
            Driver.Close();
        }
    }
}