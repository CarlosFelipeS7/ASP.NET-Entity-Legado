using EFCore.WebAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace EFCore.WebAPI.Data
{
    public class HeroiContext: DbContext //vai encapsular todas as entidades
    {
        //Boa pratica do EF, deixar nomes de listas no plural
        public DbSet<Heroi> Herois { get; set; }
        public DbSet<Batalha> Batalhas { get; set; }
        public DbSet<Arma> Armas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //faz a configuração do banco de dados
        {
            optionsBuilder.UseSqlServer(""); //string de conexão com o banco de dados
        }
    }
}
