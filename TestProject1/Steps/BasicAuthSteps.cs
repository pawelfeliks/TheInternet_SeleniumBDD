using NUnit.Framework;
using TechTalk.SpecFlow;
using TestProject1.Pages;
using TestProject1.Pages.ExternalPages;

namespace TestProject1.Steps
{
    [Binding]
    [Scope(Feature = "ABTesting")]

    public class BasicAuthSteps : MainSteps
    {
        private MainPage MainAppPage { get; set; }
        private BasicAuthPage BasicAuthPage { get; set; }
        private GitHubProjectPage GitHubProjectPage { get; set; }

        [BeforeScenario]
        public void ScenarioSetup()
        {
            BasicAuthPage = new BasicAuthPage(App.Driver);
            MainAppPage = new MainPage(App.Driver);
        }

        [Given(@"I have opened a page BasicAuth")]
        public void GivenIHaveOpenedAPageBasicAuth()
        {
            BasicAuthPage = MainAppPage.NavigateToSubPage<BasicAuthPage>(MainAppPage.LinkBasicAuth);
        }

        [When(@"I have entered ""(.*)"" in the ""(.*)"" field")]
        public void WhenIHaveEnteredInTheField(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I press the ""(.*)"" button")]
        public void WhenIPressTheButton(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"The title of the page is '(.*)'")]
        public void ThenTheHeaderOfThePageIs(string title)
        {
            Assert.AreEqual(title, BasicAuthPage.GetPageTitle(), "Title of a home page is wrong");
        }

        [Given(@"I have clicked on the image in the right top on the page ABTesting")]
        public void GivenIHaveClickedOnTheImageInTheRightTopOnThePageABTesting()
        {
            GitHubProjectPage = BasicAuthPage.NavigateToGitHubProjectPage();
        }

        [Then(@"The image on the right top page ABTesting directs us to page '(.*)'")]
        public void ThenTheImageOnTheRightTopPageABTestingDirectsUsToPage(string p0)
        {
            Assert.AreEqual(GitHubProjectPage.PageUrl, GitHubProjectPage.GetPageUrl());
        }

        [Then(@"The sentence '(.*)' is in the text")]
        public void ThenTheSentenceIsInTheText(string text)
        {
            Assert.True(BasicAuthPage.Content.Text.Contains(text), "There is no such sentence");
        }

    }

}