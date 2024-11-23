using Microsoft.EntityFrameworkCore;

namespace GestionEquiposMedicos.Modelos
public class Cliente
{
    public int ClienteID { get; set; }
    public string NombreCliente { get; set; }
    public string Dirección { get; set; }
    public string Teléfono { get; set; }
    public string CorreoElectrónico { get; set; }
    public ICollection<Transaccion> HistorialRentas { get; set; }
}
