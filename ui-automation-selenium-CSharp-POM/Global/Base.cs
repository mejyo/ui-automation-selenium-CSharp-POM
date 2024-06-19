﻿using app_automation.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using static app_automation.Global.GlobalDefinitions;

namespace app_automation.Global
{
    class Base
    {
        #region To access URLs
        public static string URL = "https://www.seek.com.au/";
        #endregion


        #region setup and tear down
        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            NavigateUrl();
            ImplicitWaitTime(20);
            Login loginObj = new Login();
            loginObj.LoginSteps();
        }

        [TearDown]
        public void TearDown()
        {

            GlobalDefinitions.driver.Close();

        }
        #endregion

    }
}