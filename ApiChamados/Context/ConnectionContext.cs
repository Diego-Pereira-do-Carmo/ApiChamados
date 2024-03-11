using ApiChamados.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiChamados.Context
{
    public class ConnectionContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Called> Called { get; set; }
        public DbSet<CalledStatus> CalledStatus { get; set; }
    }
}
