using System;

namespace ProjetoCrud.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message) : base(message)
        { 

        }
    }
}
