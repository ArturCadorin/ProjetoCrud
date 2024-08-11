using Microsoft.AspNetCore.Mvc;
using ProjetoCrud.Models;
using ProjetoCrud.Models.ViewModels;
using ProjetoCrud.Services;

namespace ProjetoCrud.Controllers
{
    public class SellersController : Controller
    {
        // Injeção de dependência
        public readonly SellerService _sellerService;
        public readonly DepartmentService _departmentService;

        public SellersController(SellerService sellerService, DepartmentService departmentService)
        {
            _sellerService = sellerService;
            _departmentService = departmentService;
        }

        // passando a lista de Seller para a view
        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }

        // Criando Seller 
        public IActionResult Create()
        {
            var departments = _departmentService.FindAll();
            var viewModel = new SellerFormViewModel { Departments = departments };
            return View(viewModel);
        }

        // Método post para criação do Seller
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }

        // Deletando Seller
        public IActionResult Remove(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var obj = _sellerService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        // Método Post para deleção do seller
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Remove(int id) 
        { 
            _sellerService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        // Mostrando os detalhes do Seller
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var obj = _sellerService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }
    }
}
