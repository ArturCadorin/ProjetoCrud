using System;

namespace ProjetoCrud.Services.Exceptions
{
    // Exceções
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message) : base(message)
        { 

        }
    }
}
