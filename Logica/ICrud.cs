using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Logica
{
    public interface ICrud<T>
    {
        bool Guardar(T entidad);
        List<T> Consultar();
        bool Actualizar(T NuevaEntidad);
        bool Borrar(int Id);
        bool Validar(T entidad);
        T BuscarPorId(int id);
    }
}
