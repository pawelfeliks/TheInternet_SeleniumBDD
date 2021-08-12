using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TestProject1.Pages
{
    public class BasicAuthPage : BasePage
    {
        public BasicAuthPage() { }
        public BasicAuthPage(IWebDriver driver) : base(driver) { } //przekazanie drivera do podstrony
        public IWebElement Content => Driver.FindElement(By.XPath("/html/body/div[2]/div/div/p"));

        public const string PageUrl = "https://the-internet.herokuapp.com/basic_auth";

        public void Open()
        {
            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/basic_auth");
            Driver.Manage().Window.Maximize();
        }
    }
}
