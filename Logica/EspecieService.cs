using System;
using System.Collections.Generic;
using System.Linq;
using Dato;
using Entidad;
namespace Logica
{
    public class EspecieService : ICrud<Especie>
    {
        private readonly IRepository<Especie> datoEspecie;
        public EspecieService()
        {
            datoEspecie = new DatoEspecie();
        }
        public string Guardar(Especie entidad)
        {
            try
            {
                string mensaje = string.Empty;
                if (Validar(entidad, out mensaje))
                    mensaje = datoEspecie.Guardar(entidad);

                return mensaje;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        public List<Especie> Consultar()
        {
            return datoEspecie.Consultar();
        }
        public string Actualizar(Especie NuevaEntidad)
        {
            try
            {
                string mensaje = string.Empty;
                if (Validar(NuevaEntidad, out mensaje))
                {
                    mensaje = datoEspecie.Actualizar(NuevaEntidad);
                }
                return mensaje;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        public string Borrar(int codigo)
        {
            return datoEspecie.Eliminar(codigo);
        }
        public Especie BuscarPorId(int codigo)
        {
            return datoEspecie.BuscarPorId(codigo);
        }
        public bool Validar(Especie entidad, out string mensaje)
        {
            mensaje = string.Empty;
            if (entidad == null)
            {
                mensaje = "Especie nula";
                return false;
            }
            if (entidad.Nombre.Any(char.IsDigit))
            {
                mensaje = "El nombre no puede contener numeros";
                return false;
            }
            if (Consultar().Any(e => e.Nombre.Equals(entidad.Nombre, StringComparison.OrdinalIgnoreCase)
                    && e.Codigo != entidad.Codigo))
            {
                mensaje = "El nombre de la especie ya existe";
                return false;
            }
            return true;
        }
    }
}
