using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TestProject1.Pages.ExternalPages;

namespace TestProject1.Pages
{
    public class BasePage : Page
    {
        public BasePage() { }

        public BasePage(IWebDriver driver) : base(driver) //skrót od klasy jeden poziom niżej (Page)
        {
        }

        public void Initialize(IWebDriver driver)
        {
            Driver = driver;
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
            Driver.SwitchTo().Window(Driver.WindowHandles.Last());
            WaitTillSeleniumPageIsLoaded();

            return seleniumPage;
        }

        private void WaitTillSeleniumPageIsLoaded()
        {
            WebDriverWait wait = new WebDriverWait(new SystemClock(), Driver, TimeSpan.FromSeconds(5), TimeSpan.FromMilliseconds(300));
            IWebElement image = wait.Until((driver) => driver.FindElement(By.XPath("//img")));
        }

        public ABTestingPage NavigateToABTestingPage()
        {
            LinkABTesting.Click();
            ABTestingPage abTestingPage = new ABTestingPage(Driver);

            return abTestingPage;
        }

        public AddRemovePage NavigateToAddRemovePage()
        {
            LinkAddRemove.Click();
            AddRemovePage addRemovePage = new AddRemovePage(Driver);

            return addRemovePage;
        }

        public T NavigateToSubPage<T>(IWebElement elementToClick) where T : BasePage, new()
        {
            elementToClick.Click();
            Driver.SwitchTo().Window((Driver.WindowHandles.Last())); // odpowiednie okno
            T subPage = new T();
            subPage.Initialize(Driver);
            // waitTillPageIsLoaded(); 

            return subPage;
            // NavigateToSubPage<AddRemovePage>;
        }
        

    }
}