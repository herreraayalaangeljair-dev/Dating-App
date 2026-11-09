

using API.Entidades;
using Microsoft.EntityFrameworkCore;
namespace API.Data;

public class AppDbContext (DbContextOptions options): DbContext(options)
{
    public DbSet<Appuser> Users { get; set; }
}
