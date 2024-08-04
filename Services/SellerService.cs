using ProjetoCrud.Data;
using ProjetoCrud.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoCrud.Services
{
    public class SellerService
    {
        private readonly ProjetoCrudContext _context;

        public SellerService(ProjetoCrudContext context)
        {
            _context = context;
        }

        // Procurando por Seller no banco de dados

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }

}
    