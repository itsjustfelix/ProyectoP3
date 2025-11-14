using System.Collections.Generic;
using Entidad;
namespace Dato
{
    public interface ICitaRepository : IRepository<Cita>
    {
        List<citasPorFechas> obtenerCitasPorFechas();
    }
}
