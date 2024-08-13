using System;

namespace ProjetoCrud.Services.Exceptions
{
    // Exceções
    public class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException(string message) : base(message) { }
    }
}
