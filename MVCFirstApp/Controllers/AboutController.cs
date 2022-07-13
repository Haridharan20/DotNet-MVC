using Microsoft.AspNetCore.Mvc;

namespace MVCFirstApp.Controllers
{
    [Route("[controller]")]
    public class AboutController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
