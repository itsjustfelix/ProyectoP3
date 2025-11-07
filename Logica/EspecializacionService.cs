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
        public string Guardar(Especializacion entidad)
        {
            try
            {
                string mensaje = string.Empty;
                if (Validar(entidad, out mensaje))
                    mensaje = datoEspecializacion.Guardar(entidad);

                return mensaje;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<Especializacion> Consultar()
        {
            return datoEspecializacion.Consultar();
        }

        public string Actualizar(Especializacion NuevaEntidad)
        {
            try
            {
                string mensaje = string.Empty;
                if (Validar(NuevaEntidad, out mensaje))
                    mensaje = datoEspecializacion.Actualizar(NuevaEntidad);

                return mensaje;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Borrar(int codigo)
        {
            return datoEspecializacion.Eliminar(codigo);
        }

        public Especializacion BuscarPorId(int codigo)
        {
            return datoEspecializacion.BuscarPorId(codigo);
        }

        public bool Validar(Especializacion entidad, out string mensaje)
        {
            mensaje = string.Empty;
            if (entidad == null)
            {
                mensaje = "La especializacion no puede ser nula";
            }
            if (entidad.Nombre.Any(char.IsDigit))
            {
                mensaje = "El nombre no puede contener numeros";
                return false;
            }
            if (Consultar().Any(e => e.Nombre.Equals(entidad.Nombre, StringComparison.OrdinalIgnoreCase)
                   && e.Codigo != entidad.Codigo))
            {
                mensaje = "El nombre de la especializacion ya existe";
                return false;
            }
            return true;
        }
    }
}
