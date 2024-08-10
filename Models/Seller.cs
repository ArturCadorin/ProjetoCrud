using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace ProjetoCrud.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; } 
        public double BaseSalary { get; set; }
        // public Department = departamento do seller(vendedor)
        public Department Department { get; set; }
        public int? DepartmentId {  get; set; }
        // public ICollection<SalesRecord> = lista de genéricos para registar as vendas do seller(vendedor)
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller() { }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        // Adcionando uma venda 
        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }
        // Removendo uma venda
        public void RemoveSales(SalesRecord sr) 
        { 
            Sales.Remove(sr); 
        }

        // Total as vendas em um determinado intervalo de datas
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
