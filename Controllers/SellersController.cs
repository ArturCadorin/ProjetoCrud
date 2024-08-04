using Microsoft.AspNetCore.Mvc;

namespace ProjetoCrud.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
