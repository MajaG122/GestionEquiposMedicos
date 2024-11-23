using Microsoft.EntityFrameworkCore;

namespace GestionEquiposMedicos.Modelos


public class EquipoService
{
    private readonly AppDbContext _context;

    public EquipoService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Equipo>> GetEquiposAsync()
    {
        return await _context.Equipos.ToListAsync();
    }
}
