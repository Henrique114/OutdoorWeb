using Microsoft.AspNetCore.Mvc;

namespace Outdoor.Controllers
{
    public class EventoCulturalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
