using AgenciaMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace AgenciaMVC.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Login > Logins{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source= THAÍS;Initial Catalog=AgenciaMVC;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Login>(t =>
            {
                t.ToTable("Login");

                t.HasKey(p => p.CodLogin);

                t.Property(p => p.Email).HasMaxLength(50).IsRequired();
                t.Property(p => p.Senha).HasColumnType("CHAR(8)").IsRequired();
                
            });
        }
    }
}
