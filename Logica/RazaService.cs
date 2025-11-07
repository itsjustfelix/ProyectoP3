using System;
using System.Collections.Generic;
using System.Linq;
using Dato;
using Entidad;
namespace Logica
{
    public class RazaService : IServiceRaza
    {
        private readonly IRepository<Raza> datoRaza;
        public RazaService()
        {
            datoRaza = new DatoRaza();
        }
        public string Guardar(Raza entidad)
        {
            try
            {
                string mensaje = string.Empty;
                if (Validar(entidad, out mensaje))
                    mensaje = datoRaza.Guardar(entidad);

                return mensaje;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<Raza> Consultar()
        {
            return datoRaza.Consultar();
        }
        public string Actualizar(Raza NuevaEntidad)
        {
            try
            {
                string mensaje = string.Empty;
                if (Validar(NuevaEntidad, out mensaje))
                    mensaje = datoRaza.Actualizar(NuevaEntidad);

                return mensaje;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        public string Borrar(int codigo)
        {
            return datoRaza.Eliminar(codigo);
        }
        public Raza BuscarPorId(int codigo)
        {
            return datoRaza.BuscarPorId(codigo);
        }
        public bool Validar(Raza entidad, out string mensaje)
        {
            mensaje = string.Empty;
            if (entidad == null)
            {
                mensaje = "Raza nula";
                return false;
            }
            if (entidad.Especie == null)
            {
                mensaje = "Especie nula";
                return false;
            }
            if (entidad.Nombre.Any(char.IsDigit))
            {
                mensaje = "El nombre no puede contener numeros";
                return false;
            }
            //if (Consultar().Any(r => r.nombre.Equals(entidad.nombre) && r.especie.id.Equals(entidad.especie.id)))
            //    throw new ArgumentException("El nombre de la raza ya existe para la especie seleccionada");
            return true;
        }
        public List<Raza> BuscarPorCualidad(int cualidad)
        {
            return Consultar().Where(r => r.Especie.Codigo.Equals(cualidad)).ToList();
        }//esto lo debo hacer en la base da datos
    }
}
