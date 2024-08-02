using ProjetoCrud.Models;
using ProjetoCrud.Models.Enums;
using System;
using System.Linq;

namespace ProjetoCrud.Data
{
    public class SeedingService
    {

        private ProjetoCrudContext _context;

        // injeção de dependencia
        public SeedingService(ProjetoCrudContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            // Testa se existe registro 
            if(_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return; // DB ja foi populado
            }

            Department dep1 = new Department(1, "Artur");
            Department dep2 = new Department(2, "Bruno");
            Department dep3 = new Department(3, "Fernando");
            Department dep4 = new Department(4, "Guilherme");

            Seller sel1 = new Seller(1, "Artur Cadorin", "arturcadorin@hotmail.com", new DateTime(1995, 11, 24), 2000.0, dep1); 
            Seller sel2 = new Seller(2, "Fernando Romanzina", "fernandorom@hotmail.com", new DateTime(1993, 10, 20), 1800.0, dep3); 
            Seller sel3 = new Seller(3, "Bruno Vassoler", "brunovassoler@hotmail.com", new DateTime(1995, 8, 14), 1650.0, dep2);

            SalesRecord sr1 = new SalesRecord(1, new DateTime(2024, 8, 2), 10000.0, SaleStatus.Billed, sel1);
            SalesRecord sr2 = new SalesRecord(2, new DateTime(2024, 8, 2), 8700.0, SaleStatus.Pending, sel2);

            // Mandando para o banco de dados
            _context.Department.AddRange(dep1, dep2, dep3, dep4);
            _context.Seller.AddRange(sel1, sel2, sel3);
            _context.SalesRecord.AddRange(sr1, sr2);

            _context.SaveChanges();
        }
    }
}
