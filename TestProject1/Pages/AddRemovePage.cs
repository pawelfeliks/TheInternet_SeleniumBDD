using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TestProject1.Pages.ExternalPages;

namespace TestProject1.Pages
{
    public class AddRemovePage : BasePage
    {
        public const string PageTitle = "The Internet";
        public AddRemovePage(IWebDriver driver) : base(driver) //przekazanie drivera do podstrony
        {
        }

        public IWebElement MainHeader => Driver.FindElement(By.XPath("/html/body/div[2]/div/h3"));
        public const string PageUrl = "https://the-internet.herokuapp.com/add_remove_elements/";

        public void Open()
        {
            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/add_remove_elements/");
            Driver.Manage().Window.Maximize();
        }

        public void ClickOnTheAddButton()
        {
            AddButton.Click();
        }

    }
}