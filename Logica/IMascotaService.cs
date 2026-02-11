using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
namespace Logica
{
    public interface IMascotaService :IWriteService<Mascota>,IReadService<MascotaDTO>,IDataEditService<MascotaEdicionDTO>
    {
        List<MascotaDTO> buscarPorRazaEspeciePropietario(string texto);
        List<MascotaDTO> BuscarPorPropietario(string propietarioId);
        int totalMascotas();
    }
}
