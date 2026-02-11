using System;
using System.Collections.Generic;
using System.Linq;
using Dato;
using Entidad;

namespace Logica
{
    public class PropietarioService : IPropietarioService
    {
        private readonly IWriteReapository<Propietario> WriteRepository;
        private readonly IReadRepository<Propietario> ReadRepository;
        public PropietarioService()
        {
            WriteRepository = new DatoPropietario();
            ReadRepository = new DatoPropietario();
        }
        public bool Guardar(Propietario entidad)
        {
            try
            {
                if (Validar(entidad) && IdUnico(entidad.Cedula))
                    return WriteRepository.Guardar(entidad);
                else
                    return false;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
        public List<Propietario> Consultar()
        {
            return ReadRepository.Consultar();
        }
        public bool Actualizar(Propietario NuevaEntidad)
        {
            try
            {
                if (Validar(NuevaEntidad))
                    return WriteRepository.Actualizar(NuevaEntidad);
                else
                    return false;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }


        }
        public bool Borrar(string Id)
        {
            try
            {
                return WriteRepository.Eliminar(Id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public Propietario buscar(string id)
        {
            return ReadRepository.BuscarPorId(id);
        }
        public bool Validar(Propietario entidad)
        {
            if (entidad == null) throw new Exception("Propietario nulo");
            if (entidad.NombreCompleto.Any(char.IsDigit)) throw new Exception("El nombre no puede contener numeros");
            if (entidad.Cedula.ToString().Length < 8 || entidad.Cedula.ToString().Length > 10) throw new Exception("La cedula debe tener entre 8 y 10 digitos");
            if (entidad.Cedula.ToString().Any(char.IsLetter)) throw new Exception("La cedula no puede contener letras");
            if (entidad.Telefono.Any(char.IsLetter)) throw new Exception("El telefono no puede contener letras");
            if (entidad.Telefono.Length != 10) throw new Exception("El telefono debe tener 10 digitos");
            if (entidad.Email.AsParallel().Count(c => c == '@') != 1 || entidad.Email.StartsWith("@") || entidad.Email.EndsWith("@"))
                throw new Exception("El correo electronico debe contener un solo @ y no puede estar al inicio o al final");
            return true;
        }
        public bool IdUnico(string id)
        {
            if (buscar(id) != null) throw new ArgumentException("La Cedula ya esta registrada en la base de datos");
            return true;
        }
        public List<Propietario> BuscarPorCedula(string cedula)
        {
            return ReadRepository.Consultar().Where(p => p.Cedula == cedula).ToList();
        }
        public List<Propietario> BuscarPorNombreApellido(string texto)
        {
            return ReadRepository.Consultar().Where(p => p.NombreCompleto.Trim().ToLower().Contains(texto)).ToList();
        }
    }
}
