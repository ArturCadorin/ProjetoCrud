using System;

namespace ProjetoCrud.Models.ViewModels
{
    // Classe para as telas de Erro
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public string Message { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}