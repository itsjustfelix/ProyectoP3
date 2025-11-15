using System;
using System.Collections.Generic;
using System.Linq;
using Dato;
using Entidad;
namespace Logica
{
    public class EspecieService : IEspecieService
    {
        private readonly IRepository<Especie> especieRepository;
        public EspecieService()
        {
            especieRepository = new DatoEspecie();
        }
        public bool Guardar(Especie entidad)
        {
            try
            {
                if (Validar(entidad))
                    return especieRepository.Guardar(entidad);
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public List<Especie> Consultar()
        {
            return especieRepository.Consultar();
        }
        public bool Actualizar(Especie NuevaEntidad)
        {
            try
            {
                if (Validar(NuevaEntidad))
                    return especieRepository.Actualizar(NuevaEntidad);
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
            return especieRepository.Eliminar(codigo);
        }
        public Especie BuscarPorId(int codigo)
        {
            return especieRepository.BuscarPorId(codigo);
        }
        public bool Validar(Especie entidad)
        {
            if (entidad == null) throw new Exception("Especie nula");
            if (entidad.Nombre.Any(char.IsDigit)) throw new Exception("El nombre no puede contener numeros");
            if (Consultar().Any(e => e.Nombre.Equals(entidad.Nombre, StringComparison.OrdinalIgnoreCase)
                    && e.Codigo != entidad.Codigo)) throw new Exception("El nombre de la especie ya existe.");
            return true;
        }
        public List<Especie> BuscarPorNombre(string nombre)
        {
            return especieRepository.Consultar()
                .Where(e => e.Nombre.IndexOf(nombre, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
        }
    }
}
