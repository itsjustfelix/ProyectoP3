using System;
using System.Collections.Generic;
using System.Linq;
using Dato;
using Entidad;
namespace Logica
{
    public class RazaService : IRazaService
    {
        private readonly IRepository<Raza> razaRepository;
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
        public List<Raza> Consultar()
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
        public bool Borrar(int codigo)
        {
            return razaRepository.Eliminar(codigo);
        }
        public Raza BuscarPorId(int codigo)
        {
            return razaRepository.BuscarPorId(codigo);
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
        public List<Raza> BuscarPorEspecie(int codigo)
        {
            return Consultar().Where(r => r.Especie.Codigo.Equals(codigo)).ToList();
        }
        public List<Raza> BuscarPorNombre(string nombre)
        {
            return Consultar().Where(r => r.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public List<Raza> BuscarPorNombreEspecie(string nombre)
        {
            return Consultar().Where(r => r.Especie.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
