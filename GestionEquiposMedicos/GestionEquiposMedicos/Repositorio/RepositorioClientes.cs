using GestionEquiposMedicos.Modelos;
using Microsoft.EntityFrameworkCore;

namespace GestionEquiposMedicos.Repositorio
{
    public class RepositorioClientes : IRepositorioClientes
    {
        private readonly BaseDBContext _context;
        public RepositorioClientes(BaseDBContext context)
        {
            _context = context;
        }

        public async Task<Cliente> Add(Cliente cliente)
        {
            await _context.Clientes.AddAsync(cliente);
            await _context.SaveChangesAsync();
            return cliente;
        }

        public async Task Delete(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Cliente?> Get(int id)
        {
            return await _context.Clientes.FindAsync(id);
        }

        public async Task<List<Cliente>> GetAll()
        {
            return await _context.Clientes.ToListAsync();
        }

        public async Task<List<Cliente>> GetClientes()
        {
            return await _context.Clientes.ToListAsync();
        }

        public async Task Update(int id, Cliente cliente)
        {
            var clienteactual = await _context.Clientes.FindAsync(id);
            if (clienteactual != null)
            {
                clienteactual.NombreCliente = cliente.NombreCliente;
                clienteactual.Direccion = cliente.Direccion;
                clienteactual.Telefono = cliente.Telefono;
                clienteactual.CorreoE = cliente.CorreoE;
                clienteactual.Historial = cliente.Historial;
                await _context.SaveChangesAsync();
            }
        }
    }
}
