using OpenQA.Selenium;

namespace AmazonTests.PageObjects
{
    public class ShoppingCartPage
    {
        private readonly IWebDriver _driver;

        public ShoppingCartPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public bool IsProductInCart(string productName)
        {
            Thread.Sleep(5000);
            var cartItem = _driver.FindElement(By.XPath($"//span[contains(text(),'{productName}')]"));
            return cartItem.Displayed;
        }

        public string GetCartAmount()
        {
            Thread.Sleep(5000);
            var cartAmount = _driver.FindElement(By.CssSelector(".a-color-price.hlb-price.a-inline-block.a-text-bold"));
            return cartAmount.Text;
        }

        public bool IsItemInCart()
        {
            try
            {
                // Check if the item is in the cart
                var itemElement = _driver.FindElement(By.CssSelector("your_item_selector"));
                return itemElement != null && itemElement.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public string GetTotalAmount()
        {
            try
            {
                // Get the total amount from the cart
                var totalAmountElement = _driver.FindElement(By.CssSelector("your_total_amount_selector"));
                return totalAmountElement.Text;
            }
            catch (NoSuchElementException)
            {
                return "0"; // Return '0' or throw an exception based on your requirement
            }
        }
    }
}
