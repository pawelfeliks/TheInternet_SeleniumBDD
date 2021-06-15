using System;
using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Opera;

namespace TestProject1
{
    public class Application
    {
        private readonly AppContext _appContext = new AppContext();
        public AppContext AppContext => _appContext;

        public IWebDriver Driver { get; set; }

        public Application()
        {
            HandleBrowser();
        }

        private void HandleBrowser()
        {
            if (AppContext.Browser == "chrome")
            {
                Driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            }
            else if (AppContext.Browser == "edge")
            {
                Driver = new EdgeDriver(@"C:/Windows/System32/");
            }
            else if (AppContext.Browser == "firefox")
            {
                Driver = new FirefoxDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            }
            else if (AppContext.Browser == "opera")
            {
                Driver = new OperaDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(AppContext.Browser));
            }
        }
    }
}