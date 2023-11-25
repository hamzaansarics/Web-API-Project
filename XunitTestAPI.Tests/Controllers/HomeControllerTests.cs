using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XunitTestAPI.Controllers;

namespace XunitTestAPI.Tests.Controllers
{
    public class HomeControllerTests
    {
        [Fact]
        public void HomeController_Index_ValidResult()
        {
            //AAA -Triple A is the standard in every industry for unit tesing
            //Arange -They hanle the reference of particular method which we want to test
            HomeController controller = new HomeController();
            string expectedresult = "I'm from Index method";

            //Act - They handle action to test the actual method
            string actualresult = controller.Index();

            //Asset - They handle to verify the actual and expected result as equal or not
            Assert.Equal(actualresult, expectedresult);
        }
    }
}
