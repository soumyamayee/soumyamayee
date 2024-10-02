using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using AmazonUIBDD.Pages;
using TechTalk.SpecFlow;

namespace AmazonUIBDD.Pages
{
    public class AmazonHomePage :BasePage
    {
        
        // Constructor to pass the WebDriver to the parent class
        public AmazonHomePage(IWebDriver driver) : base(driver) { }
        // Locators
        private IWebElement ElectronicsSection => driver.FindElement(By.LinkText("Electronics & Computers"));

        public void NavigateToElectronicsSection()
        {
            ClickOnElement(ElectronicsSection);
        }
    }
}
