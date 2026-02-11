using System.Collections.Generic;
using Entidad;

namespace Logica
{
    public interface IConsultaService : IWriteService<Consulta>, IReadService<ConsultaDTO>
    {
        string GenerarDocumento(ConsultaDTO entidad, byte[] logo);
        string enviarEmail(string email, string rutaDocumento);
        List<ConsultaDTO> buscarPorFecha(string fecha);
        List<ConsultaDTO> buscarPorVeterinarioMascota(string texto);
        int totalConsultasAsistdas(string fecha);
        string ObtenerEmailPropietaio(string codigo);
    }
}
