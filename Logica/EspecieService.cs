using System;
using System.Collections.Generic;
using System.Linq;
using Dato;
using Entidad;
namespace Logica
{
    public class EspecieService : IEspecieService
    {
        private readonly IWriteReapository<Especie> WriteRepository;
        private readonly IReadRepository<Especie> ReadRepository;
        public EspecieService()
        {
            WriteRepository = new DatoEspecie();
            ReadRepository = new DatoEspecie();
        }
        public bool Guardar(Especie entidad)
        {
            try
            {
                if (Validar(entidad))
                    return WriteRepository.Guardar(entidad);
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
            return ReadRepository.Consultar();
        }
        public bool Actualizar(Especie NuevaEntidad)
        {
            try
            {
                if (Validar(NuevaEntidad))
                    return WriteRepository.Actualizar(NuevaEntidad);
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
            return WriteRepository.Eliminar(codigo);
        }
        public Especie buscar(string codigo)
        {
            return ReadRepository.BuscarPorId(codigo);
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
            return ReadRepository.Consultar()
                .Where(e => e.Nombre.Trim().ToLower().Contains(nombre))
                .ToList();
        }
    }
}
