using Microsoft.AspNetCore.Mvc;

namespace JuanProject.Areas.AdminArea.Controllers
{
    public class CategoryController : Controller
    {
        [Area("AdminArea")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
