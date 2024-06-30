using OpenQA.Selenium;
using System.Threading;
using NUnit.Framework;


namespace App_automation.pages

{
    public class AddProduct
    {
        public void AddProductActions(IWebDriver driver)

        {

            IWebElement SearchProducts = driver.FindElement(By.CssSelector("input[placeholder='Search products, brands, and more...']"));
            Thread.Sleep(5000);
            SearchProducts.Click();

            IWebElement SearchInput = driver.FindElement(By.CssSelector("input[placeholder='Search products, brands…']"));
            Thread.Sleep(5000);
            SearchInput.SendKeys("Computer");

            IWebElement SearchButton = driver.FindElement(By.CssSelector("button[title='Start Search']"));
            Thread.Sleep(5000);
            SearchButton.Click();

            IWebElement Item = driver.FindElement(By.CssSelector("img[alt='ASUS Vivobook Go 15 E510KA 15.6\" FHD Laptop (128GB) [Intel Celeron]']"));
            Thread.Sleep(5000);
            Item.Click();

            IWebElement AddToCart = driver.FindElement(By.CssSelector(".Button_fullWidthVariant__ickenoa.Button_typeVariants_action__ickeno6.Button_solidButtonStyles__ickeno0.be8y1j0"));
            Thread.Sleep(5000);
            AddToCart.Click();

            IWebElement ReviewCart = driver.FindElement(By.CssSelector(".Button_typeVariants_primary__ickeno4.Button_solidButtonStyles__ickeno0.zrarkx7"));
            Thread.Sleep(5000);
            ReviewCart.Click();

            IWebElement RemoveItem = driver.FindElement(By.CssSelector(".remove-link.remove-button"));
            Thread.Sleep(5000);
            RemoveItem.Click();

            Assert.Pass("Selected product has been removed from the Cart sucessfully!");
        }

    }
}
