using OpenQA.Selenium;

namespace AmazonTests.PageObjects
{
    public class AmazonHomePage
    {
        private readonly IWebDriver _driver;
       // private readonly string _url = "https://www.amazon.com/";
        private readonly string _url = "https://www.amazon.co.uk/";

        public AmazonHomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void NavigateToHomePage()
        {
            _driver.Navigate().GoToUrl(_url);
            // Maximize the browser window
            _driver.Manage().Window.Maximize();
            Thread.Sleep(5000);
             // Accept cookies
            //AcceptCookies();
            //Thread.Sleep(5000);
        }

        public void AcceptCookies()
        {
        try
        {
            // Find the accept cookies button by its XPath or CSS selector
            // Replace the XPath or CSS selector with the one specific to your website
            IWebElement acceptCookiesButton = _driver.FindElement(By.XPath("//span[contains(text(), 'Accept')]"));

            // Click on the accept cookies button
            acceptCookiesButton.Click();
        }
        catch (NoSuchElementException)
        {
            // Handle exception if the accept cookies button is not found
            // You can log a message or continue without accepting cookies
            Console.WriteLine("Accept cookies button not found.");
        }
        }

        public void SearchForItem(string searchText)
        {
            Thread.Sleep(5000);
            var searchBox = _driver.FindElement(By.Id("twotabsearchtextbox"));
            searchBox.SendKeys(searchText);
            searchBox.SendKeys(Keys.Enter);
        }
    }
}
