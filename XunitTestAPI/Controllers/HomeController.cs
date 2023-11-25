using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace XunitTestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        public string Index()
        {
            return "I'm from Index method";
        }
    }
}
