using ApiChamados.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiChamados.Context
{
    public class ConnectionContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-I0JB759\\SQLEXPRESS01;Database=ApiChamados;Integrated Security=SSPI;TrustServerCertificate=True;");
        }

        public DbSet<Called> Called { get; set; }
        public DbSet<CalledStatus> CalledStatus { get; set; }
    }
}
