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
        // public ICollection<Seller> = coleção generica da classe sellers(vendedores)
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department(){ }
        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        // Adcionando um vendedor
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
