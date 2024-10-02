using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonUIBDD.Pages
{
    public class BasePage
    {
        protected IWebDriver driver;

        // Constructor to initialize the WebDriver
        public BasePage(IWebDriver _driver)
        {
            driver = _driver;
        }
        
        // Common method to perform a search
        public void PerformSearch(IWebElement ele,string searchText)
        {
            ele.SendKeys(searchText);
            ele.Submit();           
        }
        // Click On Element
        public void ClickOnElement(IWebElement ele)
        {
            ele.Click();
        }

        // Common method to get the page title
        public string GetPageTitle()
        {
            return driver.Title;
        }

        // Method to navigate to the home page
        public void NavigateToHomePage()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.amazon.co.uk");
        }
        // JavaScript click for hidden elements
        public void ClickElementWithJS(WebElement ele)
        {
            try
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("arguments[0].click();", ele);
            }
            catch (Exception e)
            {
                
            }
        }
        // JavaScript sendkeys for hidden elements
        public void SendTextWithJS(IWebElement ele, String text)
        {
            try
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("arguments[0].value='" + text + "';", ele);
            }
            catch (Exception e)
            {
               
            }
        }
        // JavaScript scrollto elements
        public void scrollToEleWithJS(IWebElement ele)
        {
            try
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("arguments[0].scrollIntoView(true);", ele);
            }
            catch (Exception e)
            {
               
            }

        }
        // JavaScript get innnertext elements
        public String getInnerTextWithJS(IWebElement ele)
        {
            String text = "";
            try
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                text = (String)js.ExecuteScript("return arguments[0].innerText;", ele);
                return text;
            }
            catch (Exception e)
            {
               
            }
            return text;
        }
        // Generic explicit wait method for element to be clickable
        public WebElement waitForElementToBeClickable(IWebElement ele, Long timeoutInSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, Duration.ofSeconds(timeoutInSeconds));
            return wait.Until(ExpectedConditions.elementToBeClickable(ele));
        }

        // Generic explicit wait method for visibility of element in the page
        public WebElement waitForElementToBevisible(WebElement ele, Long timeoutInSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, Duration.ofSeconds(timeoutInSeconds));
            return wait.until(ExpectedConditions.visibilityOf(ele));
        }

        // Generic explicit wait method for text to be present in a specific element
        public boolean waitForTextToBePresentInElement(By locator, String text, Long timeoutInSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, Duration.ofSeconds(timeoutInSeconds));
            return wait.until(ExpectedConditions.textToBePresentInElementLocated(locator, text));
        }

        /**
	     * Highlights a given WebElement by changing its background color.
	     * @param element - The WebElement to highlight.
	     */
        public void highlightElement(IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            // Save the original style of the element
            String originalStyle = element.getAttribute("style");
            // Set the new style to highlight the element
            js.executeScript("arguments[0].setAttribute('style', arguments[1]);", element, "border: 2px solid red;");
            // Pause for a short time so that the highlight is visible
            try
            {
                Thread.sleep(500); // Highlight is visible for half a second
            }
            catch (InterruptedException e)
            {
                e.printStackTrace();
            }
        }

        /**
	     * Performs a click on the given element.
	     * @param element - The WebElement to be clicked.
	     */
        public void clickElement(IWebElement element)
        {
            try
            {
                actions.moveToElement(element).click().build().perform();
            }
            catch (Exception e)
            {
                e.printStackTrace();
            }

        }

        /**
	     * Performs a right-click (context click) on the given element.
	     * @param element - The WebElement to right-click on.
	     */
        public void rightClickElement(IWebElement element)
        {
            try
            {
                actions.contextClick(element).build().perform();
            }
            catch (Exception e)
            {
                
            }

        }

        /**
	     * Performs a double-click on the given element.
	     * @param element - The WebElement to double-click on.
	     */
        public void doubleClickElement(IWebElement element)
        {
            try
            {
                actions.doubleClick(element).build().perform();
            }
            catch (Exception e)
            {
                e.printStackTrace();
            }
        }

        /**
	     * Performs a click-and-hold action on the given element.
	     * @param element - The WebElement to click and hold.
	     */
        public void clickAndHoldElement(IWebElement element)
        {
            try
            {
                actions.clickAndHold(element).build().perform();
            }
            catch (Exception e)
            {
                e.printStackTrace();
            }

        }

        /**
	     * Performs a drag-and-drop operation from the source element to the target element.
	     * @param source - The WebElement to drag from.
	     * @param target - The WebElement to drop to.
	     */
        public void dragAndDrop(IWebElement source, IWebElement target)
        {
            try
            {
                actions.dragAndDrop(source, target).build().perform();
            }
            catch (Exception e)
            {
                e.printStackTrace();
            }

        }

        /**
	     * Moves the mouse to the given element and performs a hover action.
	     * @param element - The WebElement to hover over.
	     */
        public void hoverOverElement(IWebElement element)
        {
            try
            {
                actions.moveToElement(element).build().perform();
            }
            catch (Exception e)
            {
                e.printStackTrace();
            }

        }

        /**
	     * Moves the slider to a specific offset.
	     * @param slider - The WebElement representing the slider.
	     * @param xOffset - The horizontal offset to move the slider.
	     * @param yOffset - The vertical offset to move the slider (usually 0 for horizontal sliders).
	     */
        public void moveSlider(IWebElement slider, int xOffset, int yOffset)
        {
            actions.clickAndHold(slider).moveByOffset(xOffset, yOffset).release().build().perform();
        }

        /**
	     * Sends a series of keys to the specified element.
	     * @param element - The WebElement to send keys to.
	     * @param keys - The keys to send (e.g., Keys.ENTER).
	     */
        public void sendKeys(IWebElement element, String keys)
        {
            try
            {
                actions.moveToElement(element).sendKeys(element, keys).build().perform();
            }
            catch (Exception e)
            {
                
            }

        }

        public static double findSliderPosition(double value, double minValue, double maxValue)
        {
            if (value <= minValue || value >= maxValue)
            {
                throw new IllegalArgumentException("Value must be more than £98 and less than £740");
            }
            // Interpolating the position of the slider
            double position = (value - minValue) / (maxValue - minValue);
            // Returning the slider position as a percentage
            return position * 100;
        }

        /**
	     * Performes click operation on the specified element.
	     * @param element - The WebElement to perform click.
	     */
        public void click(IWebElement element)
        {
            try
            {
                highlightElement(element);
                waitForElementToBeClickable(element, defaultTimeout).click();
            }
            catch (Exception e)
            {
                
            }


        }

        /**
	     * verify if element is selected.
	     * @param element - The WebElement to perform click.
	     */
        public Boolean verifyElementIsSelected(IWebElement element)
        {
            try
            {
                waitForElementToBevisible(element, defaultTimeout);
            }
            catch (Exception e)
            {
                scrollToEleWithJS(element);
                highlightElement(element);
            }
            if (!element.Selected())
            {
                return false;
            }
            return true;
        }
        /* wait
	     * 
	     */
        public void waitFor()
        {
            try
            {
                Thread.Sleep(500);
            }
            catch (Exception e)
            {
               
            }

        }


    }
}
