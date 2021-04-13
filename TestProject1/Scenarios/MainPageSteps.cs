using System;
using TechTalk.SpecFlow;

namespace TestProject1.Scenarios
{
    [Binding]
    public class MainPageSteps
    {
        [Given(@"I have clicked on the footer")]
        public void GivenIHaveClickedOnTheFooter()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
