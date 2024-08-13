using System.Collections.Generic;

namespace ProjetoCrud.Models.ViewModels
{
    // Classe para as telas de Seller
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
    