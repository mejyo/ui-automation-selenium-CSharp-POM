﻿using App_automation.utilities;
using App_automation.Pages;
using NUnit.Framework;

namespace App_automation
{
    public static class Program
    {
        [TestFixture]
        class User : Base
        {
            [Test, Order(1)]
            public void SearchJobs()
            {
                SearchJob searchJobObj = new SearchJob();
                searchJobObj.SearchJobSteps();
            }
        }
    }
}