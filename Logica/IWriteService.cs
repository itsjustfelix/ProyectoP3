using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface IWriteService<T>
    {
        bool Guardar(T entidad);
        bool Actualizar(T NuevaEntidad);
        bool Borrar(string Id);
        bool Validar(T entidad);
    }
}
