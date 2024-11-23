using GestionEquiposMedicos.Modelos;
using GestionEquiposMedicos.Repositorio;
using Microsoft.EntityFrameworkCore;

public class TransaccionRepository : ITransaccionRepository
{
    private readonly AppDbContext _context;

    public TransaccionRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Transaccion>> GetAllAsync()
    {
        return await _context.Transacciones
            .Include(t => t.Equipo)
            .Include(t => t.Cliente)
            .ToListAsync();
    }

    public async Task<Transaccion> GetByIdAsync(int id)
    {
        return await _context.Transacciones
            .Include(t => t.Equipo)
            .Include(t => t.Cliente)
            .FirstOrDefaultAsync(t => t.TransaccionID == id);
    }

    public async Task AddAsync(Transaccion transaccion)
    {
        await _context.Transacciones.AddAsync(transaccion);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Transaccion transaccion)
    {
        _context.Transacciones.Update(transaccion);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var transaccion = await GetByIdAsync(id);
        if (transaccion != null)
        {
            _context.Transacciones.Remove(transaccion);
            await _context.SaveChangesAsync();
        }
    }
}
