using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Tools;
using ApiControleEstoque.Models;

namespace ApiControleEstoque.Data
{
    public class EstoqueContext : DbContext
    {
        public DbSet<Categoria> Categoria {get; set;}
        public DbSet<Produto> Produto {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=BDEstoque;User Id=sa;Password=SQLServer2019;");
        }
    }
}
