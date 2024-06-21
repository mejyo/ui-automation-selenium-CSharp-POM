using App_automation.utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace App_automation.Pages

{
    class Login
    {
        public Login()
        {
            PageFactory.InitElements(GlobalDefinitions.driver, this);
        }

         #region  Initialize Web Elements 
        //Finding the Sign Link
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[4]/div/div[2]/div[2]/section/div/nav/div[2]/div[1]/div/div/div[1]/div/a")]
        private IWebElement SignIntab { get; set; }

        // Finding the Email Field
        [FindsBy(How = How.CssSelector, Using = "#emailAddress")]
        private IWebElement Email { get; set; }

        //Finding the Password Field
        [FindsBy(How = How.CssSelector, Using = "#password")]
        private IWebElement Password { get; set; }

        //Finding the Login Button
        [FindsBy(How = How.CssSelector, Using = "button[type='submit']")]
        private IWebElement LoginBtn { get; set; }

        #endregion

        internal void LoginSteps()
        {
            GlobalDefinitions.NavigateUrl();
            Thread.Sleep(5000);

            SignIntab.Click();
            Thread.Sleep(5000);
            Email.SendKeys("hi.its.jyo123@gmail.com");
            Thread.Sleep(5000);
            Password.SendKeys("testabc123");
            Thread.Sleep(5000);
            LoginBtn.Click();
            Thread.Sleep(5000);
        }
    }
}
