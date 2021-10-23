using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiControleEstoque.Models
{
    public class Produto
    {
        public int ID {get; set;}
        public string Nome {get; set;}
        public Categoria Categoria {get; set;}
        public int CategoriaID {get; set;}
        public string Modelo {get; set;}
        public string Descricao {get; set;}
        public string Tamanho {get; set;}
        public decimal Preco {get; set;}
        public int Quantidade {get; set;}
        
    }
}