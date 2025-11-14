using System;
using System.Collections.Generic;
using System.Linq;
using Dato;
using Entidad;
namespace Logica
{
    public class EspecializacionService : ICrud<Especializacion>
    {
        private readonly IRepository<Especializacion> datoEspecializacion;

        public EspecializacionService()
        {
            datoEspecializacion = new DatoEspecializacion();
        }
        public bool Guardar(Especializacion entidad)
        {
            try
            {
                if (Validar(entidad))
                    return datoEspecializacion.Guardar(entidad);
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Especializacion> Consultar()
        {
            return datoEspecializacion.Consultar();
        }
        public bool Actualizar(Especializacion NuevaEntidad)
        {
            try
            {
                if (Validar(NuevaEntidad))
                    return datoEspecializacion.Actualizar(NuevaEntidad);
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Borrar(int codigo)
        {
            return datoEspecializacion.Eliminar(codigo);
        }
        public Especializacion BuscarPorId(int codigo)
        {
            return datoEspecializacion.BuscarPorId(codigo);
        }
        public bool Validar(Especializacion entidad)
        {
            if (entidad == null) throw new Exception("La especializacion no puede ser nula.");
            if (entidad.Nombre.Any(char.IsDigit)) throw new Exception("El nombre no puede contener numeros");
            if (Consultar().Any(e => e.Nombre.Equals(entidad.Nombre, StringComparison.OrdinalIgnoreCase)
                   && e.Codigo != entidad.Codigo)) throw new Exception("El nombre de la especializacion ya existe.");
            return true;
        }
        public List<Especializacion> BuscarPorNombre(string nombre)
        {
            return datoEspecializacion.Consultar()
                .Where(e => e.Nombre.IndexOf(nombre, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
        }
    }
}
