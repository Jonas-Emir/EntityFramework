using Microsoft.EntityFrameworkCore;
using System;

namespace Alura.Loja.Testes.ConsoleApp
{
    //Criar um contexto e definir quais classes serão persistidas e informar no evento de configuração qual banco ele vai usar
    public class LojaContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }


        //Método de configuração do contexto LojaContext OnConfigure
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = LojaDB; Trusted_Connection = true;");
        }
    }
}