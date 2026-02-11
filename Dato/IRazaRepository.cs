using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dato
{
    public interface IRazaRepository : IWriteReapository<Raza>, IReadRepository<RazaDTO>, IDataEditRepository<RazaEdicionDTO>
    {
        List<RazaDTO> consultarRazasPorEspecie(string id);
    }
}
