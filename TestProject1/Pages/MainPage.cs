using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TestProject1.Pages
{
    public class MainPage : BasePage
    {
        public const string PageTitle = "The Internet";
        public MainPage(IWebDriver driver) : base(driver)
        {
        }

        public void Open()
        {
            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
        }
    }
}