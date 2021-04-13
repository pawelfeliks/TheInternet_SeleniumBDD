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
    [Binding] //klasa jest związana ze scenariuszem Feature = MainPage

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

        //SpecFlow + BDD
        [Given(@"I have opened main page")]
        public void GivenIHaveOpenedMainPage()
        {
            //Selenium and Driver - C#
            MainAppPage.Open();
        }

        [Then(@"The title of main page is '(.*)'")]
        public void ThenTheTitleOfMainPageIs(string title)
        {
            Assert.AreEqual(title, Driver.Title, "Title of a home page is wrong");
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
        public void GivenIHaveClickedOnTheImageInTheRightTop(string footer)
        {
            
        }

        [Then(@"The image directs us to page '(.*)'")]
        public void ThenTheImageDirectsUsToPage(string p0)
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