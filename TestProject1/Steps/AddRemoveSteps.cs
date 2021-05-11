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
    [Scope(Feature = "AddRemove")]

    public class AddRemoveSteps
    {
        private IWebDriver Driver { get; set; }
        private MainPage MainAppPage { get; set; }
        private AddRemovePage AddRemovePage { get; set; }
        private GitHubProjectPage GitHubProjectPage { get; set; }
        private SeleniumPage SeleniumPage { get; set; }

        [BeforeScenario]
        public void ScenarioSetup()
        {
            Driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            AddRemovePage = new AddRemovePage(Driver);
            MainAppPage = new MainPage(Driver);
        }

        [Given(@"I have opened a page AddRemove")]
        public void GivenIHaveOpenedAPageAddRemove()
        {
            AddRemovePage.Open();
        }

        [Then(@"The title of a page is '(.*)'")]
        public void ThenTheTitleOfAPageIs(string title)
        {
            Assert.AreEqual(title, MainAppPage.GetPageTitle(), "Title of a home page is wrong");
        }

        [Given(@"I have clicked on the button Add Element")]
        public void GivenIHaveClickedOnTheButtonAddElement()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"The button Delete appears")]
        public void ThenTheButtonDeleteAppears()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have clicked on the button Add Element (.*) times")]
        public void GivenIHaveClickedOnTheButtonAddElementTimes(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click button Delete (.*) times")]
        public void WhenIClickButtonDeleteTimes(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"There should be (.*) buttons Delete")]
        public void ThenThereShouldBeButtonsDelete(int p0)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
