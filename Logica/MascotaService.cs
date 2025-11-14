using System;
using System.Collections.Generic;
using System.Linq;
using Dato;
using Entidad;

namespace Logica
{
    public class MascotaService : IMascotaService
    {
        private readonly IRepository<Mascota> mascotaRepository;
        public MascotaService()
        {
            mascotaRepository = new DatoMascota();
        }
        public bool Guardar(Mascota entidad)
        {
            try
            {
                if (Validar(entidad))
                    return mascotaRepository.Guardar(entidad);
                else 
                    return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Mascota> Consultar()
        {
            return mascotaRepository.Consultar();
        }
        public bool Actualizar(Mascota NuevaEntidad)
        {
            try
            {
                if (Validar(NuevaEntidad))
                    return mascotaRepository.Actualizar(NuevaEntidad);
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
            return mascotaRepository.Eliminar(codigo);
        }
        public Mascota BuscarPorId(int id)
        {
            return mascotaRepository.BuscarPorId(id);
        }
        public bool Validar(Mascota entidad)
        {
            if (entidad == null) throw new Exception("Mascota nula");
            if (entidad.Propietario == null) throw new Exception("Propietario nulo");
            if (entidad.Especie == null)throw new Exception("Especie nula");
            if (entidad.Raza == null) throw new Exception("Raza nula");
            if (entidad.Nombre.Any(char.IsDigit)) throw new Exception("El nombre de la mascota no puede contener numeros");
            return true;
        }
        public List<Mascota> BuscarPorPropietario(int propietarioId)
        {
            return mascotaRepository.Consultar().Where(m => m.Propietario.Cedula == propietarioId).ToList();
        }
        public List<Mascota> BuscarPorEspecie(string especie)
        {
            return mascotaRepository.Consultar().Where(m => m.Especie.Nombre.Equals(especie,StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public List<Mascota> BuscarPorRaza(string raza)
        {
           return mascotaRepository.Consultar().Where(m => m.Raza.Nombre.Equals(raza,StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public int totalMascotas()
        {
            return Consultar().Count;
        }
    }
}
