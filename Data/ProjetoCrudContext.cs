using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoCrud.Models;

namespace ProjetoCrud.Data
{
    public class ProjetoCrudContext : DbContext
    {
        public ProjetoCrudContext (DbContextOptions<ProjetoCrudContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoCrud.Models.Department> Department { get; set; }
    }
}
