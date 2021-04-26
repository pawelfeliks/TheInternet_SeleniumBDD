using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TestProject1.Pages.ExternalPages
{
    public class GitHubProjectPage : Page
    {
        public const string PageUrl = "https://github.com/saucelabs/the-internet";

        public GitHubProjectPage(IWebDriver driver) : base(driver)
        {
        }

        
    }
}
