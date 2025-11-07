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
        string Guardar(T entidad);
        List<T> Consultar();
        string Actualizar(T NuevaEntidad);
        string Borrar(int Id);
        bool Validar(T entidad, out string mensaje);
        T BuscarPorId(int id);
    }
}
