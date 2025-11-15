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
        List<Mascota> BuscarPorPropietario(int propietarioId);
        List<Mascota> BuscarPorEspecie(string especie);
        List<Mascota> BuscarPorRaza(string raza);
        int totalMascotas();
    }
}
