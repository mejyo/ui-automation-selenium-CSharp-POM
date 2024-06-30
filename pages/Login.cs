using OpenQA.Selenium;
using System.Threading;

namespace App_automation.pages

{
    public class Login
    {
        public void LoginActions(IWebDriver driver)

        {
            driver.Navigate().GoToUrl("https://www.jbhifi.com.au/");

            driver.Manage().Window.Maximize();

            Thread.Sleep(5000);

            IWebElement SingInTab = driver.FindElement(By.CssSelector("div[id='header-account'] button[type='button']"));
            Thread.Sleep(5000);
            SingInTab.Click();

            IWebElement Email = driver.FindElement(By.Id("email"));
            Email.SendKeys("hi.its.jyo123@gmail.com");
            Thread.Sleep(5000);

            IWebElement Password = driver.FindElement(By.Id("password"));
            Password.SendKeys("Testabc123");
            Thread.Sleep(5000);

            IWebElement Login = driver.FindElement(By.Id("continueProxy"));

            Login.Click();
            Thread.Sleep(5000);
        }

    }
}
    
