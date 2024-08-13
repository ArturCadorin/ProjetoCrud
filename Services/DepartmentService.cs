using ProjetoCrud.Data;
using ProjetoCrud.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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

        // Método assincrono que retorna uma lista com os Departamentos ordenados
        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }


    }
}
