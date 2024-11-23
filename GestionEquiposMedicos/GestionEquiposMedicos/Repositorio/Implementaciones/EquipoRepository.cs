using GestionEquiposMedicos.Modelos;
using GestionEquiposMedicos.Repositorio;
using Microsoft.EntityFrameworkCore;


public class EquipoRepository : IEquipoRepository
{
    private readonly AppDbContext _context;

    public EquipoRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Equipo>> GetAllAsync()
    {
        return await _context.Equipos.ToListAsync();
    }

    public async Task<Equipo> GetByIdAsync(int id)
    {
        return await _context.Equipos.FindAsync(id);
    }

    public async Task AddAsync(Equipo equipo)
    {
        await _context.Equipos.AddAsync(equipo);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Equipo equipo)
    {
        _context.Equipos.Update(equipo);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var equipo = await GetByIdAsync(id);
        if (equipo != null)
        {
            _context.Equipos.Remove(equipo);
            await _context.SaveChangesAsync();
        }
    }
}
