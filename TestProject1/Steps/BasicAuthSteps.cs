using NUnit.Framework;
using TechTalk.SpecFlow;
using TestProject1.Pages;
using TestProject1.Pages.ExternalPages;

namespace TestProject1.Steps
{
    [Binding]
    [Scope(Feature = "BasicAuth")]

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

        [Given(@"I have opened main page")]
        public void GivenIHaveOpenedMainPage()
        {
            MainAppPage.Open();
        }


        [Given(@"I have opened a page BasicAuth using login and password")]
        public void GivenIHaveOpenedAPageBasicAuthUsingLoginAndPassword()
        {
            App.Driver.Navigate().GoToUrl("http://admin:admin@the-internet.herokuapp.com/basic_auth");        }

        [Given(@"I have opened a page BasicAuth")]
        public void GivenIHaveOpenedAPageBasicAuth()
        {
            App.Driver.Navigate().GoToUrl("http://admin:admin@the-internet.herokuapp.com/basic_auth");        }

        [Given(@"I have clicked on the image in the right top on the page BasicAuth")]
        public void GivenIHaveClickedOnTheImageInTheRightTopOnThePageBasicAuth()
        {
            GitHubProjectPage = BasicAuthPage.NavigateToGitHubProjectPage();
        }

        [Then(@"The image on the right top page BasicAuth directs us to page '(.*)'")]
        public void ThenTheImageOnTheRightTopPageBasicAuthDirectsUsToPage(string p0)
        {
            Assert.AreEqual(GitHubProjectPage.PageUrl, GitHubProjectPage.GetPageUrl());
        }

        [Then(@"The sentence '(.*)' is in the text")]
        public void ThenTheSentenceIsInTheText(string text)
        {
            Assert.True(BasicAuthPage.Content.Text.Contains(text), "There is no such sentence");
        }

        [AfterScenario]
        public void ScenarioTeardown()
        {
            CloseApp();
        }
    }

}