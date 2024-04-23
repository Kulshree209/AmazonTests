using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using AmazonTests.PageObjects;

namespace AmazonTests.StepDefinitions
{
    [Binding]    public class AmazonSteps
    {
            private IWebDriver _driver;
        private AmazonHomePage? _amazonHomePage;
        private ProductPage? _productPage;
        private ShoppingCartPage? _shoppingCartPage;

        public AmazonSteps()
        {
            _driver = null!;
            _amazonHomePage = null!;
            _productPage = null!;
            _shoppingCartPage = null!;
        }

        [BeforeScenario]
        public void Setup()
        {
            //var chromeDriverService = ChromeDriverService.CreateDefaultService(@"./Drivers", "chromedriver.exe");
            var chromeDriverService = ChromeDriverService.CreateDefaultService("/Users/kulshreepatil/AmazonTests/Drivers", "chromedriver");
            _driver = new ChromeDriver(chromeDriverService);
            _amazonHomePage = new AmazonHomePage(_driver);
            _productPage = new ProductPage(_driver);
            _shoppingCartPage = new ShoppingCartPage(_driver);
        }

        [AfterScenario]
        public void Teardown()
        {
            _driver?.Quit();
        }

        [Given(@"I navigate to https://www.amazon.com/ as an unregistered user")]
        public void GivenINavigateToAmazonAsAnUnregisteredUser()
        {
            _amazonHomePage.NavigateToHomePage();
        }

        [When(@"I search for ""(.*)""")]
        public void WhenISearchFor(string searchText)
        {
            _amazonHomePage.SearchForItem(searchText);
        }

        [When(@"I add the corresponding item to the cart")]
        public void WhenIAddTheCorrespondingItemToTheCart()
        {
            _productPage.AddToCart();
        }

        [Then(@"I navigate to cart and validate the correct item and amount is displayed")]
       /* public void ThenINavigateToCartAndValidateTheCorrectItemAndAmountIsDisplayed()
        {
            var isProductInCart = _shoppingCartPage.IsProductInCart("TP-Link N450 WiFi Router - Wireless Internet Router for Home (TL-WR940N)");
            Assert.IsTrue(isProductInCart);
            
            var cartAmount = _shoppingCartPage.GetCartAmount();
            Assert.AreEqual("$xx.xx", cartAmount); // Replace $xx.xx with the actual price
        }*/

        [NUnit.Framework.Test]
        public void ThenINavigateToCartAndValidateTheCorrectItemAndAmountIsDisplayed()
        {
        //_shoppingCartPage.NavigateToShoppingCart();
        // Replace Assert with Verify
        //Assert.IsTrue(_shoppingCartPage.IsItemInCart(), "Item is not in the cart.");
        //Assert.AreEqual("expected_amount", _shoppingCartPage.GetTotalAmount(), "Incorrect total amount.");
        }

[TearDown]
        public void Cleanup()
        {
            if (_driver != null)
            {
        _driver.Dispose();
            }

        }

    }
}
