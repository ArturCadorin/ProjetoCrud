using ProjetoCrud.Data;
using ProjetoCrud.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProjetoCrud.Services.Exceptions;
using System.Threading.Tasks;

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

        // Método assincrono que retorna uma lista com os Seller
        public async Task<List<Seller>> FindAllAsync()
        {
            return await _context.Seller.ToListAsync();
        }

        // Método assincrono que retorna Seller pelo seu ID
        public async Task<Seller> FindByIdAsync(int id) 
        { 
        return await _context.Seller.Include(obj => obj.Department).FirstOrDefaultAsync(obj => obj.Id == id);
        }

        // Método assincrono que remove Seller   
        public async Task RemoveAsync(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            await _context.SaveChangesAsync();
        }

        // Método assincrono que inseri Seller no banco de dados
        public async Task InsertAsync(Seller obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        // Método assincrono que atualiza Seller no banco de dados
        public async Task UpdateAsync(Seller obj) 
        {
            // Verificando se Seller já existe no banco de dados
            var hasAny = await _context.Seller.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new KeyNotFoundException("Id not found");
            }
            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
    