using OpenQA.Selenium;

namespace TestProject1.Pages
{
    public class Page 
    {
        public Page() { }
        protected IWebDriver Driver { get; set; } //driver jest wgrywany z biblioteką SeleniumWebDriverChrome
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
