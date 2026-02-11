using System;
using System.Collections.Generic;
using System.Linq;
using Dato;
using Entidad;
namespace Logica
{
    public class RazaService : IRazaService
    {
        private readonly IRazaRepository razaRepository;
        public RazaService()
        {
            razaRepository = new DatoRaza();
        }
        public bool Guardar(Raza entidad)
        {
            try
            {
                if (Validar(entidad))
                    return razaRepository.Guardar(entidad);
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<RazaDTO> Consultar()
        {
            return razaRepository.Consultar();
        }
        public bool Actualizar(Raza NuevaEntidad)
        {
            try
            {
                if (Validar(NuevaEntidad))
                    return razaRepository.Actualizar(NuevaEntidad);
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public bool Borrar(string codigo)
        {
            return razaRepository.Eliminar(codigo);
        }
        public RazaDTO buscar(string codigo)
        {
            return razaRepository.BuscarPorId(codigo);
        }
        public bool Validar(Raza entidad)
        {
            if (entidad == null) throw new Exception("Raza nula");
            if (entidad.EspecieCodigo == null) throw new Exception("Especie nula");
            if (entidad.Nombre.Any(char.IsDigit)) throw new Exception("El nombre no puede contener numeros");
            // esta validacion debe estar en la base de datos
            //if (Consultar().Any(r => r.Nombre.Equals(entidad.Nombre) && r.Especie.Codigo.Equals(entidad.Especie.Codigo)))
            //    throw new ArgumentException("El nombre de la raza ya existe para la especie seleccionada");
            return true;
        }
        //esta funcion debe estar en la base de datos.
        public List<RazaDTO> BuscarPorEspecie(string codigo)
        {
            return razaRepository.consultarRazasPorEspecie(codigo);
        }
        public List<RazaDTO> BuscarPorNombre(string nombre)
        {
            return Consultar().Where(r => r.Nombre.ToLower().Trim().Contains(nombre)).ToList();
        }
        public List<RazaDTO> BuscarPorNombreEspecie(string texto)
        {
            return Consultar().Where(r => r.NombreEspecie.ToLower().Trim().Contains(texto) 
            || r.Nombre.Trim().ToLower().Contains(texto)).ToList();
        }
        public RazaEdicionDTO ObtenerDatosEdicion(string id)
        {
           return razaRepository.ObtenerDatosParaEdicion(id);
        }
    }
}
