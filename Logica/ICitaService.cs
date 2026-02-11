using System.Collections.Generic;
using Entidad;

namespace Logica
{
    public interface ICitaService : IWriteService<Cita>,IReadService<CitaDTO>, IDataEditService<CitaEdicionDTO>
    {
        List<citasPorFechas> ObtenerCitasPorFechas();
        List<CitaDTO> buscarPorFecha(string fecha);
        List<CitaDTO> buscarPorVeterinarioMascota(string texto);
        int totalCitasHoy(string fecha);
        int totalCitas();
        string ObtenerCodigoMascotaPorCita(string codigoCita);
        string ObtenerCedulaVeterinarioPorCita(string codigoCita);
    }
}
