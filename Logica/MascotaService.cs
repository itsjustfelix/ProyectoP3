using System;
using System.Collections.Generic;
using System.Linq;
using Dato;
using Entidad;

namespace Logica
{
    public class MascotaService : IMascotaService
    {
        private readonly IWriteReapository<Mascota> WriteRepository;
        private readonly IReadRepository<MascotaDTO> ReadRepository;
        private readonly IDataEditRepository<MascotaEdicionDTO> EditRepository;
        public MascotaService()
        {
            WriteRepository = new DatoMascota();
            ReadRepository = new DatoMascota();
            EditRepository = new DatoMascota();

        }
        public bool Guardar(Mascota entidad)
        {
            try
            {
                if (Validar(entidad))return WriteRepository.Guardar(entidad);
                else return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<MascotaDTO> Consultar()
        {
            return ReadRepository.Consultar();
        }
        public bool Actualizar(Mascota NuevaEntidad)
        {
            try
            {
                if (Validar(NuevaEntidad))return WriteRepository.Actualizar(NuevaEntidad);
                else return false;
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
        public MascotaDTO buscar(string id)
        {
            return ReadRepository.BuscarPorId(id);
        }
        public bool Validar(Mascota entidad)
        {
            if (entidad == null) throw new Exception("Mascota nula");
            if (entidad.PropietarioCedula == null) throw new Exception("Propietario nulo");
            if (entidad.EspecieCodigo == null) throw new Exception("Especie nula");
            if (entidad.RazaCodigo == null) throw new Exception("Raza nula");
            if (entidad.Nombre.Any(char.IsDigit)) throw new Exception("El nombre de la mascota no puede contener numeros");
            return true;
        }

        //esta funcion se debe hacer en la base de datos.
        public List<MascotaDTO> BuscarPorPropietario(string propietarioId)
        {
            //return ReadRepository.Consultar().Where(m => m.Propietario.Cedula == propietarioId).ToList();
            throw new NotImplementedException();
        }

        public List<MascotaDTO> buscarPorRazaEspeciePropietario(string texto)
        {
            return Consultar().Where(m => m.NombreRaza.Trim().ToLower().Contains(texto) ||
                                                   m.NombreEspecie.Trim().ToLower().Contains(texto) ||
                                                   m.NombrePropietario.Trim().ToLower().Contains(texto) ||
                                                   m.Nombre.ToLower().Trim().Contains(texto)).ToList();
            throw new NotImplementedException();
        }
        public int totalMascotas()
        {
            return Consultar().Count;
        }

        public MascotaEdicionDTO ObtenerDatosEdicion(string id)
        {
            return EditRepository.ObtenerDatosParaEdicion(id);
        }
    }
}
