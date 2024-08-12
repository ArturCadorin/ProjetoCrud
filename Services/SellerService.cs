using ProjetoCrud.Data;
using ProjetoCrud.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProjetoCrud.Services.Exceptions;
using Microsoft.AspNetCore.Mvc.ActionConstraints;

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

        // Retornando todos os Seller do banco de dados

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        // Retornando vendedor do banco de dados e realizando o JOIN com o departamento
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

        // Inserindo Seller no banco de dados
        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        // Atualizando Seller no banco de dados
        public void Update(Seller obj) 
        {
            // se não existir
            if (!_context.Seller.Any(x => x.Id == obj.Id))
            {
                throw new KeyNotFoundException("Id not found");
            }
            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }
            catch(DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
    