using Microsoft.AspNetCore.Mvc;

namespace MoviesAPI.Controllers
{
    public class Movies : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
