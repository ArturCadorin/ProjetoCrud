using Microsoft.EntityFrameworkCore;
using ProjetoCrud.Models;

namespace ProjetoCrud.Data
{
    public class ProjetoCrudContext : DbContext
    {
        // Instanciando Banco de Dados (utilizando EF)
        public ProjetoCrudContext (DbContextOptions<ProjetoCrudContext> options)
            : base(options)
        {
        }

        // Tabelas do Banco de Dados (utilizando EF)
        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
