using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
namespace Logica
{
    public interface IMascotaService :ICrud<Mascota>
    {
        List<Mascota> buscarPorRazaEspeciePropietario(string texto);
        List<Mascota> BuscarPorPropietario(int propietarioId);
        int totalMascotas();
    }
}
