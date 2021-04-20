using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TestProject1.Pages.ExternalPages
{
    public class SeleniumPage : Page
    {
        public const string PageUrl = "http://elementalselenium.com/";

        public SeleniumPage(IWebDriver driver) : base(driver)
        {

        }
    }
}
