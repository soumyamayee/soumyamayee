using AmazonUIBDD.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonUIBDD.StepDefinitions
{
    public class MobilePhonesPage :BasePage
    {
        public MobilePhonesPage(IWebDriver driver):base(driver) {}
        // Locators
        private IWebElement ElectronicsSection => driver.FindElement(By.LinkText("Electronics & Computers"));

        public void NavigateToElectronicsSection()
        {
            ElectronicsSection.Click();
        }
    }
}
