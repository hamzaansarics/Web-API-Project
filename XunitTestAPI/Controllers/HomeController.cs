using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using XunitTestAPI.Repository;

namespace XunitTestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IEmailRepo emailRepo;
        public HomeController(IEmailRepo emailRepo)
        {
            this.emailRepo = emailRepo;
        }
        public string Index()
        {
            return "I'm from Index method";
        }
        public int Sum(int left, int right)
        {
            return left + right;
        }
        public bool SendEmail()
        {
            return emailRepo.SendEmail();
        }
        public void RecievedEmail()
        {
            emailRepo.RecievedEmail();
        }
    }
}
