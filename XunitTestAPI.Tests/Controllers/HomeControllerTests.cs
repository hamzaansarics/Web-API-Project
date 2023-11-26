using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XunitTestAPI.Controllers;
using XunitTestAPI.Repository;

namespace XunitTestAPI.Tests.Controllers
{
    public class HomeControllerTests
    {
        Mock<IEmailRepo> mock = new Mock<IEmailRepo>();
        
        private readonly IEmailRepo _emailRepo;
        public HomeControllerTests()
        {
            _emailRepo = new EmailRepo();
        }

        [Fact]
        public void HomeController_Index_ValidResult()
        {
            //AAA -Triple A is the standard in every industry for unit tesing
            //Arange -They hanle the reference of particular method which we want to test
            HomeController controller = new HomeController(_emailRepo);
            string expectedresult = "I'm from Index method";

            //Act - They handle action to test the actual method
            string actualresult = controller.Index();

            //Asset - They handle to verify the actual and expected result as equal or not
            Assert.Equal(actualresult, expectedresult);
        }
        [Fact]
        public void HomeController_Sum_of_2_2_should_be_4()
        {
            var controller = new HomeController(_emailRepo);
            mock.Setup(x => x.SendEmail()).Returns(true);
            var result = controller.Sum(2, 2);
           
            if (controller.Sum(2, 2) != 4)
                throw new Exception($"Sum of 2 & 2 should be 4 but it's {result}");

            Assert.Equal(result, 4);
        }
        [Fact]
        public void HomeController_SendEmail_ValidResult()
        {
            

            mock.Setup(x => x.SendEmail()).Returns(true);
            var controller = new HomeController(_emailRepo);

            //var result = controller.SendEmail();
            //Assert.Equal(true, result);

        }
    }
}
