using Microsoft.AspNetCore.Mvc;

namespace Cuba_Staterkit.Controllers
{
    public class ReportsController : Controller
    {
        public IActionResult MQaberReports()
        {
            return View();
        }
        public IActionResult KaflalaaReports()
        {
            return View();
        }
    }
}
