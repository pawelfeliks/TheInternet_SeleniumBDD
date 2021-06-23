using OpenQA.Selenium;

namespace TestProject1.Pages
{
    public class Page 
    {
        public Page() { }
        protected IWebDriver Driver { get; set; } //driver jest wgrywany z biblioteką SeleniumWebDriverChrome
        public IWebElement LinkABTesting => Driver.FindElement(By.XPath("/html/body/div[2]/div/ul/li[1]/a"));
        public IWebElement LinkAddRemove => Driver.FindElement(By.XPath("/html/body/div[2]/div/ul/li[2]/a"));
        public Page(IWebDriver driver)
        {
            Driver = driver;
        }

        public string GetPageTitle()
        {
            return Driver.Title;
        }

        public string GetPageUrl()
        {
            return Driver.Url;
        }
    }
}
