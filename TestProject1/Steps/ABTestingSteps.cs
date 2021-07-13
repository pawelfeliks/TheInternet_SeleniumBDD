using NUnit.Framework;
using TechTalk.SpecFlow;
using TestProject1.Pages;
using TestProject1.Pages.ExternalPages;

namespace TestProject1.Steps
{
    [Binding]
    [Scope(Feature = "ABTesting")]

    public class ABTestingSteps : MainSteps
    {
        private MainPage MainAppPage { get; set; }
        private ABTestingPage ABTestingPage { get; set; }
        private GitHubProjectPage GitHubProjectPage { get; set; }
        private SeleniumPage SeleniumPage { get; set; }

        [BeforeScenario]
        public void ScenarioSetup()
        {
            ABTestingPage = new ABTestingPage(App.Driver);
            MainAppPage = new MainPage(App.Driver);
        }


        [Given(@"I have opened main page")]
        public void GivenIHaveOpenedMainPage()
        {
            MainAppPage.Open();
        }

        [When(@"I click A/B Testing link")]
        public void WhenIClickABTestingLink()
        {
            ABTestingPage = MainAppPage.NavigateToSubPage<ABTestingPage>(MainAppPage.LinkABTesting);
        }

        [Then(@"The ABTesting page is opened")]
        public void ThenTheABTestingPageIsOpened()
        {
            Assert.AreEqual(ABTestingPage.PageUrl, MainAppPage.GetPageUrl());
        }

        [Given(@"I have opened a page A/B Testing")]
        public void GivenIHaveOpenedAPageABTesting()
        {
            ABTestingPage = MainAppPage.NavigateToSubPage<ABTestingPage>(MainAppPage.LinkABTesting); ;
        }

        [Then(@"the title of a page is '(.*)'")]
        public void ThenTheTitleOfAPageIs(string title)
        {
            Assert.AreEqual(title, ABTestingPage.GetPageTitle(), "Title of a home page is wrong");
        }

        [Given(@"I have clicked on the footer on the page ABTesting")]
        public void GivenIHaveClickedOnTheFooterOnThePageABTesting()
        {
            SeleniumPage = ABTestingPage.NavigateToSeleniumPage();
        }

        [Then(@"The footer of the page ABTesting directs us to page '(.*)'")]
        public void ThenTheFooterOfThePageABTestingDirectsUsToPage(string seleniumPageUrl)
        {
            Assert.AreEqual(seleniumPageUrl, SeleniumPage.GetPageUrl());
        }

        [Given(@"I have clicked on the image in the right top on the page ABTesting")]
        public void GivenIHaveClickedOnTheImageInTheRightTopOnThePageABTesting()
        {
            GitHubProjectPage = ABTestingPage.NavigateToGitHubProjectPage();
        }

        [Then(@"The image on the right top page ABTesting directs us to page '(.*)'")]
        public void ThenTheImageOnTheRightTopPageABTestingDirectsUsToPage(string p0)
        {
            Assert.AreEqual(GitHubProjectPage.PageUrl, GitHubProjectPage.GetPageUrl());
        }

        [Then(@"The sentence '(.*)' is in the text")]
        public void ThenTheSentenceIsInTheText(string text)
        {
            Assert.True(ABTestingPage.Content.Text.Contains(text), "There is no such sentence");
        }

        [AfterScenario]
        public void ScenarioTeardown()
        {
            CloseApp();
        }
    }
}