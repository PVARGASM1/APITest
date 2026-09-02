using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Api.Models;

namespace PruebaTecnica.Api.Data
{
    public class AppDbContext : DbContext
    {
      public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
      public DbSet<Producto> Productos { get; set; } = null;
    }
}
