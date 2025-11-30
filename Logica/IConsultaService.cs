using System.Collections.Generic;
using Entidad;

namespace Logica
{
    public interface IConsultaService : ICrud<Consulta>
    {
        string GenerarDocumento(Consulta entidad);
        string enviarEmail(string email, string rutaDocumento);
        List<Consulta> buscarPorFecha(string fecha);
        List<Consulta> buscarPorVeterinarioMascota(string texto);
        int totalConsultasAsistdas(string fecha);
    }
}
