using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TestProject1.Pages.ExternalPages;

namespace TestProject1.Pages
{
    public class BasePage : Page
    {
        public IWebElement LinkFooter => Driver.FindElement(By.LinkText("Elemental Selenium"));
        public IWebElement RightTopImage => Driver.FindElement(By.XPath("/html/body/div[2]/a/img"));
        public BasePage(IWebDriver driver) : base(driver)
        {
        }

        public void ScrollToTheBottom()
        {
            IJavaScriptExecutor javaScriptExecutor = (IJavaScriptExecutor) Driver;
            javaScriptExecutor.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
            WaitTillPageIsScrolled();
        }

        private void WaitTillPageIsScrolled()
        {
            WebDriverWait wait = new WebDriverWait(new SystemClock(), Driver, TimeSpan.FromSeconds(3), TimeSpan.FromMilliseconds(100));
            IWebElement element = wait.Until((driver) => driver.FindElement(By.XPath("/html/body/div[3]/div/div/a")));
        }

        public GitHubProjectPage NavigateToGitHubProjectPage()
        {
            RightTopImage.Click();
            GitHubProjectPage gitHubProjectPage = new GitHubProjectPage(Driver);
            WaitTillGitHubProjectPageIsLoaded();

            return gitHubProjectPage;
        }

        private void WaitTillGitHubProjectPageIsLoaded()
        {
            WebDriverWait wait = new WebDriverWait(new SystemClock(), Driver, TimeSpan.FromSeconds(5), TimeSpan.FromMilliseconds(300));
            IWebElement element = wait.Until((driver) => driver.FindElement(By.ClassName("avatar-user")));
        }

        public SeleniumPage NavigateToSeleniumPage()
        {
            LinkFooter.Click();
            SeleniumPage seleniumPage = new SeleniumPage(Driver);
            WaitTillSeleniumPageIsLoaded();

            return seleniumPage;
        }

        private void WaitTillSeleniumPageIsLoaded()
        {
            WebDriverWait wait = new WebDriverWait(new SystemClock(), Driver, TimeSpan.FromSeconds(5), TimeSpan.FromMilliseconds(300));
            IWebElement image = wait.Until((driver) => driver.FindElement(By.XPath("/html/body/section[1]/div/img"))));
        }
    }
}