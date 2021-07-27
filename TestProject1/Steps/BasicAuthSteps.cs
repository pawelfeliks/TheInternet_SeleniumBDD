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


        [Given(@"I have opened a page BasicAuth using login and password")]
        public void GivenIHaveOpenedAPageBasicAuthUsingLoginAndPassword()
        {
            BasicAuthPage = MainAppPage.NavigateToSubPage<BasicAuthPage>(MainAppPage.LinkBasicAuth);
        }

        [Then(@"The communicate is '(.*)' \?")]
        public void ThenTheCommunicateIs(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have opened a page BasicAuth")]
        public void GivenIHaveOpenedAPageBasicAuth()
        {
            BasicAuthPage = MainAppPage.NavigateToSubPage<BasicAuthPage>(MainAppPage.LinkBasicAuth);
        }

        [Given(@"I have clicked on the image in the right top on the page BasicAuth")]
        public void GivenIHaveClickedOnTheImageInTheRightTopOnThePageABTesting()
        {
            GitHubProjectPage = BasicAuthPage.NavigateToGitHubProjectPage();
        }

        [Then(@"The image on the right top page BasicAuth directs us to page '(.*)'")]
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