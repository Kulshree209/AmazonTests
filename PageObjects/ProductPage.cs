using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AmazonTests.PageObjects
{
    public class ProductPage
    {
        private readonly IWebDriver _driver;
         private IWebDriver driver;
    private WebDriverWait wait;

        public ProductPage(IWebDriver driver)
    {
        this.driver = driver;
        this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
    }

        public void AddToCart()
        {

Thread.Sleep(5000);
            //var addToCartButton = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("input[value='Add to Cart']")));

            //var addToCartButton = driver.FindElement(By.ClassName("addToCartClass"));

            // By XPath
            var addToCartButton = driver.FindElement(By.XPath("//*[@id='a-autoid-1-announce']"));
            addToCartButton.Click();
/*
// By ID
var addToCartButton = driver.FindElement(By.Id("addToCartButtonId"));

// By Class Name
var addToCartButton = driver.FindElement(By.ClassName("addToCartClass"));

*/
            
        }
    }
}
