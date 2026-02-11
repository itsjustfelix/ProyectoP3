using Entidad;
using System.Collections.Generic;
namespace Dato
{
    public interface ICitaRepository : IWriteReapository<Cita>, IReadRepository<CitaDTO>, IDataEditRepository<CitaEdicionDTO>
    {
        List<citasPorFechas> obtenerCitasPorFechas();
        string ObtenerCodigoMascotaPorCita(string codigoCita);
        string ObtenerCedulaVeterinarioPorCita(string codigoCita);
    }
}
