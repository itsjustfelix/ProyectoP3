using System.Collections.Generic;
using Entidad;

namespace Logica
{
    internal interface ICitaService : ICrud<Cita>
    {
        List<citasPorFechas> ObtenerCitasPorFechas();
        List<Cita> buscarPorVeterinario(string nombre);
        List<Cita> buscarPorFecha(string fecha);
        int totalCitasHoy(string fecha);
        int totalCitas();
    }
}
