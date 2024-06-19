using app_automation.Global;
using app_automation.Pages;
using NUnit.Framework;

namespace app_automation
{
    public static class Program
    {
        [TestFixture]
        class User : Base
        {
            [Test, Order(1)]
            public void SearchingJobs()
            {
                SearchingJob searchingJobObj = new SearchingJob();
                searchingJobObj.SearchJobSteps();
            }
        }
    }
}