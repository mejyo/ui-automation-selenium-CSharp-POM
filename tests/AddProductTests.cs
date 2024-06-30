using App_automation.pages;
using App_automation.utilities;
using NUnit.Framework;

namespace App_automation.tests
{

    [TestFixture]

    [Parallelizable]

    class AddProductTests : CommonDriver
    {


        [Test, Order(1)]


        public void AddProduct()

        {

            AddProduct addProdObj = new AddProduct();
            addProdObj.AddProductActions(driver);

        }

    }

}
