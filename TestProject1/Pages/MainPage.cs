using OpenQA.Selenium;

namespace TestProject1.Pages
{
    public class MainPage : BasePage
    {
        public const string PageTitle = "The Internet";
        public MainPage(IWebDriver driver) : base(driver) { }

        public IWebElement MainHeader => Driver.FindElement(By.ClassName("heading"));
        public IWebElement MainFooter => Driver.FindElement(By.XPath("/html/body/div[3]/div/div"));
        public void Open()
        {
            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
            Driver.Manage().Window.Maximize();
        }
    }
}