using Microsoft.AspNetCore.Mvc;
using ProjetoCrud.Models;
using ProjetoCrud.Services;

namespace ProjetoCrud.Controllers
{
    public class SellersController : Controller
    {
        public readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        // passando a lista de Seller para a view
        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }
    }
}
