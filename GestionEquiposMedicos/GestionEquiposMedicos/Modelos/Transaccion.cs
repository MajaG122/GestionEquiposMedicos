
using Microsoft.EntityFrameworkCore;

namespace GestionEquiposMedicos.Modelos

public class Transaccion
{
    public int TransaccionID { get; set; }
    public int EquipoID { get; set; }
    public Equipo Equipo { get; set; }
    public int ClienteID { get; set; }
    public Cliente Cliente { get; set; }
    public DateTime FechaInicioRenta { get; set; }
    public DateTime FechaFinRenta { get; set; }
    public string EstadoTransaccion { get; set; }
    public decimal CostoTotal { get; set; }
}
