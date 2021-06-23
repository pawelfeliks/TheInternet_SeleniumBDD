using System.Collections.ObjectModel;
using OpenQA.Selenium;

namespace TestProject1.Pages
{
    public class AddRemovePage : BasePage
    {
        public AddRemovePage() { }
        public const string PageTitle = "The Internet";
        public AddRemovePage(IWebDriver driver) : base(driver) {} //przekazanie drivera do podstrony
        public IWebElement AddButton => Driver.FindElement(By.XPath("/html/body/div[2]/div/div/button"));
        public IWebElement DeleteButton => Driver.FindElement(By.ClassName("added-manually"));
        public ReadOnlyCollection<IWebElement> DeleteButtons => Driver.FindElements(By.ClassName("added-manually"));

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