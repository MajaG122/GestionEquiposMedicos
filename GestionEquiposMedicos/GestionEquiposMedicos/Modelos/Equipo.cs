
using Microsoft.EntityFrameworkCore;

namespace GestionEquiposMedicos.Modelos
public class Equipo
{
    public int EquipoID { get; set; }
    public string Nombre { get; set; }
    public string Descripción { get; set; }
    public string Disponibilidad { get; set; }
    public DateTime FechaMantenimiento { get; set; }
    public decimal CostoRentaDiaria { get; set; }
    public string Departamento { get; set; }
}
