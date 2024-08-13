using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ProjetoCrud.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // Coleção de Sellers
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department(){ }
        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        // Adcionando um novo Seller a coleção já existente
        public void AddSellers(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller =>  seller.TotalSales(initial, final));
        }
    }
}
