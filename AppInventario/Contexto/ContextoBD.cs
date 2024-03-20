using AppInventario.Models;
using Microsoft.EntityFrameworkCore;


namespace AppInventario.Contexto
{
    public class ContextoBD : DBContext
    {
        public ContextoBD(DbContextOptions<ContextoBD> options) : base(options)
        {
        }

        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Propriedade> Propriedades { get; set;}
    }
}
