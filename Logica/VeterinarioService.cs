using System;
using System.Collections.Generic;
using System.Linq;
using Dato;
using Entidad;
namespace Logica
{
    public class VeterinarioService : IVeterinarioService
    {
        private readonly IWriteReapository<Veterinario> WriteRepository;
        private readonly IReadRepository<VeterinarioDTO> ReadRepository;
        private readonly IDataEditRepository<VeterinarioEdicionDTO> DataEditRepository;

        public VeterinarioService()
        {
            WriteRepository = new DatoVeterinario();
            ReadRepository = new DatoVeterinario();
            DataEditRepository = new DatoVeterinario();
        }
        public bool Guardar(Veterinario entidad)
        {
            try
            {

                if (Validar(entidad) && IdUnico(entidad.Cedula)) 
                   return WriteRepository.Guardar(entidad);
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public List<VeterinarioDTO> Consultar()
        {
            return ReadRepository.Consultar();
        }
        public bool Actualizar(Veterinario NuevaEntidad)
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
        public bool Borrar(string id)
        {
            return WriteRepository.Eliminar(id);
        }
        public VeterinarioDTO buscar(string id)
        {
            return ReadRepository.BuscarPorId(id);
        }
        public bool Validar(Veterinario entidad)
        {
            if (entidad == null) throw new Exception("Veterinario nulo");
            if (entidad.EspecializacionCodigo == null) throw new Exception("La especializacion no puede ser nula.");
            if (entidad.NombreCompleto.Any(char.IsDigit)) throw new Exception("El nombre no puede contener numeros");
            if (entidad.Cedula.ToString().Length < 8 || entidad.Cedula.ToString().Length > 10) throw new Exception("La cedula debe tener entre 8 y 10 digitos");
            if (entidad.Cedula.ToString().Any(char.IsLetter)) throw new Exception("La cedula no puede contener letras");
            if (entidad.Telefono.Any(char.IsLetter)) throw new Exception("El telefono no puede contener letras");
            if (entidad.Telefono.Length != 10) throw new Exception("El telefono debe tener 10 digitos");
            return true;
        }
        public bool IdUnico(string id)
        {
            if (buscar(id) != null) throw new ArgumentException("La Cedula ya esta registrada en la base de datos");
            return true;
        }

        //esta funcion se debe hacer en la base de datos
        public List<VeterinarioDTO> buscarPorEspecializacion(string cualidad)
        {
            //return Consultar().Where(r => r.Especializacion.Codigo.Equals(cualidad)).ToList();
            throw new NotImplementedException("Esta funcion se debe hacer en la base de datos");
        }
        public List<VeterinarioDTO> bsucarPorNombreEspecializacion(string texto)
        {
            return Consultar()
                .Where(v => v.NombreEspecializacion.Trim().ToLower().Contains(texto)||
                v.NombreCompleto.Trim().ToLower().Contains(texto))
                .ToList();
        }
        public int totalVeterinarios()
        {
            return Consultar().Count;
        }

        public VeterinarioEdicionDTO ObtenerDatosEdicion(string id)
        {
            return DataEditRepository.ObtenerDatosParaEdicion(id);
        }
    }
}
