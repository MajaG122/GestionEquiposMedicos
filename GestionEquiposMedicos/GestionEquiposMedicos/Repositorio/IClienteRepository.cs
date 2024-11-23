﻿using GestionEquiposMedicos.Modelos
namespace GestionEquiposMedicos.Repositorio
    

public interface IClienteRepository
{
    Task<List<Cliente>> GetAllAsync();
    Task<Cliente> GetByIdAsync(int id);
    Task AddAsync(Cliente cliente);
    Task UpdateAsync(Cliente cliente);
    Task DeleteAsync(int id);
}
