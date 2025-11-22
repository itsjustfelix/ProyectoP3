using System.Collections.Generic;
using Entidad;

namespace Logica
{
    internal interface ICitaService : ICrud<Cita>
    {
        List<citasPorFechas> ObtenerCitasPorFechas();
        List<Cita> buscarPorFecha(string fecha);
        List<Cita> buscarPorVeterinarioMascota(string texto);
        int totalCitasHoy(string fecha);
        int totalCitas();
    }
}
