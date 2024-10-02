using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmazonUIBDD.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
namespace AmazonUIBDD.StepDefinitions

{
    [Binding]
    internal class ProductSearchSteps    {

        private IWebDriver driver;
        private BasePage basePage;
        private AmazonHomePage amazonHomePage;
        private MobilePhonesPage mobilePhonesPage;

            [Given(@"user on the Amazon UK homepage")]
            public void GivenUserOnTheAmazonUKHomepage()
            {
                basePage =new BasePage(driver);
                basePage.NavigateToHomePage();
                amazonHomePage = new AmazonHomePage(driver);
                mobilePhonesPage = new MobilePhonesPage(driver);
            }

            [When(@"user navigate to the ""([^""]*)"" category")]
            public void WhenUserNavigateToTheCategory(string Catagory)
            {
                amazonHomePage.NavigateToElectronicsSection();
            }

            [When(@"user select ""([^""]*)""")]
            public void WhenUserSelect(string SubCatagory)
            {
                
            }

            [When(@"user search for ""([^""]*)""")]
            public void WhenUserSearchFor(string Name)
            {
                
            }

            [When(@"user apply the filter ""([^""]*)""")]
            public void WhenUserApplyTheFilter(string FilterName)
            {
                
            }

            [When(@"user apply the price range filter ""([^""]*)""")]
            public void WhenUserApplyThePriceRangeFilter(string PriceRange)
            {
               
            }

            [Then(@"user should apply the brand filter ""([^""]*)""")]
            public void ThenUserShouldApplyTheBrandFilter(string BrandName)
            {
                
            }

            [Then(@"user should see a list of Samsung phones that match the specifications")]
            public void ThenUserShouldSeeAListOfSamsungPhonesThatMatchTheSpecifications()
            {
               
            }

        
       
    }
}
