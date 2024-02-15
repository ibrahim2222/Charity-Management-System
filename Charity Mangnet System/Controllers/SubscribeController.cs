using Microsoft.AspNetCore.Mvc;

namespace Cuba_Staterkit.Controllers
{
    public class SubscribeController : Controller
    {
        public IActionResult TotalMembers()
        {
            return View();
        }

        public IActionResult SMSSubscribers()
        {
            return View();
        }

        public IActionResult CustomSMSSend()
        {
            return View();
        }

    }
}
