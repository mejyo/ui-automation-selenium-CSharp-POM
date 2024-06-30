using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using App_automation.pages;

namespace App_automation.utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;

        [OneTimeSetUp]
        public void LoginActions()
        {
            driver = new ChromeDriver();

            // Login page object initialization and definition
            Login loginObj = new Login();
            loginObj.LoginActions(driver);

        }

        [OneTimeTearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}