using ProjetoCrud.Data;
using ProjetoCrud.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoCrud.Services
{
    public class SellerService
    {
        // Injeção de dependência
        private readonly ProjetoCrudContext _context;

        public SellerService(ProjetoCrudContext context)
        {
            _context = context;
        }

        // Retornando os Sellers do banco de dados

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        // Inserindo seller no banco de dados
        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }

}
    