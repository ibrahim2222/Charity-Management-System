using Microsoft.AspNetCore.Mvc;

namespace Cuba_Staterkit.Controllers
{
    public class AuthenticationController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
