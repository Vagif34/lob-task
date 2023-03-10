using Microsoft.AspNetCore.Mvc;

namespace JuanProject.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class DashboardController : Controller
    {
      
        public IActionResult Index()
        {
            return View();
        }
    }
}
