using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TestProject1.Pages.ExternalPages;

namespace TestProject1.Pages
{
    public class ABTestingPage : BasePage
    {
        public const string PageTitle = "The Internet";
        public ABTestingPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement MainHeader => Driver.FindElement(By.XPath("/html/body/div[2]/div/div/h3"));
        public IWebElement MainFooter => Driver.FindElement(By.XPath("/html/body/div[3]/div/div/a"));
        public IWebElement Content => Driver.FindElement(By.XPath("/html/body/div[2]/div/div/p"));

        public const string PageUrl = "https://the-internet.herokuapp.com/abtest";

        public void Open()
        {
            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/abtest");
            Driver.Manage().Window.Maximize();
        }

    }
}