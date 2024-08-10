using ProjetoCrud.Data;
using ProjetoCrud.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoCrud.Services
{
    public class DepartmentService
    {
        // Injeção de dependência
        private readonly ProjetoCrudContext _context;

        public DepartmentService(ProjetoCrudContext context)
        {
            _context = context;
        }

        // Retornando os departamentos do banco de dados ordenadamente
        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }


    }
}
