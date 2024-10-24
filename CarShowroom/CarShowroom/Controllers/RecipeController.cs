using Microsoft.AspNetCore.Mvc;

namespace CarShowroom.Controllers
{
    public class RecipeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
