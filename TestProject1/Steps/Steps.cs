using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using TestProject1.Pages;

namespace TestProject1.Steps
{
    [Binding] //klasa jest związana ze scenariuszem FEature = MainPage

    public class MainPageSteps
    {
        private IWebDriver Driver { get; set; }
        private MainPage MainAppPage { get; set; }

        [BeforeScenario]
        public void ScenarioSetup()
        {
            Driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            MainAppPage = new MainPage(Driver);
        }

        [Given(@"I have opened main page")]
        public void GivenIHaveOpenedMainPage()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"The title of main page is '(.*)'")]
        public void ThenTheTitleOfMainPageIs(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"The header of main page is '(.*)'")]
        public void ThenTheHeaderOfMainPageIs(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have scrolled to the down")]
        public void GivenIHaveScrolledToTheDown()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"The footer of the main page is '(.*)'")]
        public void ThenTheFooterOfTheMainPageIs(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have opened a home page")]
        public void GivenIHaveOpenedAHomePage()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"Click on the image in the right top")]
        public void GivenClickOnTheImageInTheRightTop()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"The image directs us to page '(.*)'")]
        public void ThenTheImageDirectsUsToPage(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I habe opened a home page")]
        public void GivenIHabeOpenedAHomePage()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I habe clicked on the footer")]
        public void GivenIHabeClickedOnTheFooter()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"The footer directs us to page '(.*)'")]
        public void ThenTheFooterDirectsUsToPage(string p0)
        {
            ScenarioContext.Current.Pending();
        }


        [AfterScenario]
        public void ScenarioTeardown()
        {
            Driver.Close();
        }

    }
}