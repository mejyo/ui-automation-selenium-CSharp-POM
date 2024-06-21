using App_automation.utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace App_automation.Pages
{
    class SearchJob
    {
        public SearchJob()
        {
            PageFactory.InitElements(AppFramework.Global.GlobalDefinitions.driver, this);
        }

        #region 
       

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div/div/div[1]/div[1]/div[2]/div/div[1]/a/span/span[1]/span")]
        private IWebElement JobSearchTab { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#keywords-input")]
        private IWebElement WhatBar { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#SearchBar__Where")]
        private IWebElement WhereBar { get; set; }

        [FindsBy(How = How.Id, Using = "searchButton")]
        private IWebElement SeekTab { get; set; }

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]/div[3]/div[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/span[1]/div[1]/div[1]/div[1]")]
        private IWebElement ProfileName { get; set; }


        #endregion
        internal void SearchJobSteps()
        {
            //  GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.CssSelector("_1f8pm8n0 _1s4zhqh9"), 10);
            Thread.Sleep(3000);
            JobSearchTab.Click();
            Thread.Sleep(2000);
            WhatBar.Click();
            Thread.Sleep(2000);
            WhatBar.SendKeys("Software Tester");
            Thread.Sleep(2000);
            WhereBar.Click();
           
            WhereBar.SendKeys("Sydney NSW 2000");
            Thread.Sleep(2000);
            SeekTab.Click();
            Thread.Sleep(2000);

            String actualMessage = ProfileName.Text;
            String expectedMessage = "Jyo";


            GlobalDefinitions.VerifySuccessfulMessage(expectedMessage, actualMessage, "Search Job");
        }
    }
}