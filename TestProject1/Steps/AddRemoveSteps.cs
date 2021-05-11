using System.IO;
using System.Reflection;
using System.Threading;
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
            Assert.AreEqual(title, AddRemovePage.MainHeader.Text, "Title of a home page is wrong");
        }

        [Given(@"I have clicked on the button Add Element")]
        public void GivenIHaveClickedOnTheButtonAddElement()
        {
            AddRemovePage.ClickOnTheAddButton();
        }

        [Then(@"The button Delete appears")]
        public void ThenTheButtonDeleteAppears()
        {
            Assert.True(AddRemovePage.DeleteButton.Displayed);
        }

        [Given(@"I have clicked on the button Add Element (.*) times")]
        public void GivenIHaveClickedOnTheButtonAddElementTimes(int howMany)
        {
            for (int i = 0; i < howMany; i++)
            {
                AddRemovePage.ClickOnTheAddButton();
                Thread.Sleep(500);
            }
        }

        [When(@"I click button Delete (.*) times")]
        public void WhenIClickButtonDeleteTimes(int howMany)
        {
            for (int i = 0; i < howMany; i++)
            {
                AddRemovePage.DeleteButtons[i].Click();
                Thread.Sleep(500);
            }
        }

        [Then(@"There should be (.*) buttons Delete")]
        public void ThenThereShouldBeButtonsDelete(int numberOfDeleteButtons)
        {
            Assert.AreEqual(numberOfDeleteButtons, AddRemovePage.DeleteButtons.Count, "Something wrong");
        }

        [AfterScenario]
        public void ScenarioTeardown()
        {
            Driver.Close();
            Driver.Dispose();
        }
    }
}
