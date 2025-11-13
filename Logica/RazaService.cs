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
        public bool Guardar(Raza entidad)
        {
            try
            {
                if (Validar(entidad))
                    return datoRaza.Guardar(entidad);
                else 
                    return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Raza> Consultar()
        {
            return datoRaza.Consultar();
        }
        public bool Actualizar(Raza NuevaEntidad)
        {
            try
            {
                if (Validar(NuevaEntidad))
                     return datoRaza.Actualizar(NuevaEntidad);
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
            return datoRaza.Eliminar(codigo);
        }
        public Raza BuscarPorId(int codigo)
        {
            return datoRaza.BuscarPorId(codigo);
        }
        public bool Validar(Raza entidad)
        {
            if (entidad == null) throw new Exception("Raza nula");  
            if (entidad.Especie == null) throw new Exception("Especie nula");
            if (entidad.Nombre.Any(char.IsDigit)) throw new Exception("El nombre no puede contener numeros");
            if (Consultar().Any(r => r.Nombre.Equals(entidad.Nombre) && r.Especie.Codigo.Equals(entidad.Especie.Codigo)))
               throw new ArgumentException("El nombre de la raza ya existe para la especie seleccionada");
            return true;
        }
        public List<Raza> BuscarPorCualidad(int cualidad)
        {
            return Consultar().Where(r => r.Especie.Codigo.Equals(cualidad)).ToList();
        }//esto lo debo hacer en la base da datos
    }
}
