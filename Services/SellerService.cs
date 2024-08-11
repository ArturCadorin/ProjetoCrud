using ProjetoCrud.Data;
using ProjetoCrud.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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

        // Retornando todos os vendedores do banco de dados

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        // Retornando vendedor do banco de dados e realizando o join com o departamento
        public Seller FindById(int id) 
        { 
        return _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);
        }

        // Removendo vendedor do banco de dados     
        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }

        // Inserindo seller no banco de dados
        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }

}
    