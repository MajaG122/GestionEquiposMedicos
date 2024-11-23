using Microsoft.EntityFrameworkCore;

namespace GestionEquiposMedicos.Modelos


public class AppDbContext : DbContext

{
    public DbSet<Equipo> Equipos { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Transaccion> Transacciones { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}
