using Microsoft.AspNetCore.Mvc;

namespace FinalTask.Areas.EternaAdmin.Controllers
{
    public class DashboardController : Controller
    {
        [Area("EternaAdmin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
