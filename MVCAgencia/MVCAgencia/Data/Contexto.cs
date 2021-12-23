using Microsoft.EntityFrameworkCore;
using MVCAgencia.Models;

namespace MVCAgencia.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=THAÍS;Initial Catalog=MVCAgencia;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(table =>
            {
                table.ToTable("Clientes");
                table.HasKey(p => p.CodCliente);

                table.Property(p => p.NomeCompleto).HasMaxLength(50).IsRequired();
                table.Property(p => p.CPF).HasColumnType("char(11)").IsRequired();
                table.Property(p => p.RG).HasMaxLength(10).IsRequired();
                table.Property(p => p.Nascimento).HasColumnType("date");
            });
        }
    }
}