using Microsoft.AspNetCore.Mvc;

namespace LoginAspNet.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
