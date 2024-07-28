using Microsoft.AspNetCore.Mvc;
using ProjetoCrud.Models;
using System.Collections.Generic;

namespace ProjetoCrud.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> departments = new List<Department>();
            departments.Add(new Department { Id = 1 , Name = "Departamento um"});
            departments.Add(new Department { Id = 2 , Name = "Departamento dois"});

            return View(departments);
        }
    }
}
