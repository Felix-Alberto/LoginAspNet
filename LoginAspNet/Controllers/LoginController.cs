using Microsoft.AspNetCore.Mvc;

namespace LoginAspNet.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
