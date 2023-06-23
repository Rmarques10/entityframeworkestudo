using Microsoft.EntityFrameworkCore;
using Model;

namespace Dal.SqlServer
{
    public class Context : DbContext
    {
        public Context() 
        {

        }
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-JB6ID4D\\SQLEXPRESS;Initial Catalog=Cliente;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        } 
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}
