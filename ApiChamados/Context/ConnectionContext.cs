using ApiChamados.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiChamados.Context
{
    public class ConnectionContext : DbContext
    {
        public ConnectionContext(DbContextOptions<ConnectionContext> options) :
            base(options)
        { 
        }

        public DbSet<Called> Called { get; set; }
        public DbSet<CalledStatus> CalledStatus { get; set; }
    }
}
