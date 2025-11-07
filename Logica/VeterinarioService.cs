using System;
using System.Collections.Generic;
using System.Linq;
using Dato;
using Entidad;
namespace Logica
{
    public class VeterinarioService : IServiceVeterinario, IIDUnico
    {
        private readonly IRepository<Veterinario> datoVeterinario;

        public VeterinarioService()
        {
            datoVeterinario = new DatoVeterinario();
        }
        public bool Guardar(Veterinario entidad)
        {
            try
            {

                if (Validar(entidad) && IdUnico(entidad.Cedula)) 
                   return datoVeterinario.Guardar(entidad);
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public List<Veterinario> Consultar()
        {
            return datoVeterinario.Consultar();
        }
        public bool Actualizar(Veterinario NuevaEntidad)
        {
            try
            {
                if (Validar(NuevaEntidad))
                    return datoVeterinario.Actualizar(NuevaEntidad);
                else 
                    return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Borrar(int id)
        {
            return datoVeterinario.Eliminar(id);
        }
        public Veterinario BuscarPorId(int id)
        {
            return datoVeterinario.BuscarPorId(id);
        }
        public bool Validar(Veterinario entidad)
        {
            if (entidad == null) throw new Exception("Veterinario nulo");
            
            if (entidad.Especializacion == null) throw new Exception("La especializacion no puede ser nula.");
            
            if (entidad.Nombres.Any(char.IsDigit)) throw new Exception("El nombre no puede contener numeros");
            
            if (entidad.ApellidoPaterno.Any(char.IsDigit)) throw new Exception("El apellido paterno no puede contener numeros");
            
            if (entidad.ApellidoMaterno.Any(char.IsDigit)) throw new Exception("El apellido materno no puede contener numeros");
            
            if (entidad.Cedula.ToString().Length < 8 || entidad.Cedula.ToString().Length > 10) throw new Exception("La cedula debe tener entre 8 y 10 digitos");
            
            if (entidad.Cedula.ToString().Any(char.IsLetter)) throw new Exception("La cedula no puede contener letras");
           
            if (entidad.Telefono.Any(char.IsLetter)) throw new Exception("El telefono no puede contener letras");
            
            if (entidad.Telefono.Length != 10) throw new Exception("El telefono debe tener 10 digitos");
            return true;
        }
        public bool IdUnico(int id)
        {
            if (BuscarPorId(id) != null) throw new ArgumentException("La Cedula ya esta registrada en la base de datos");
            return true;
        }
        //esto lo tengo que hacer en la base de datos
        public List<Veterinario> BuscarPorCualidad(int cualidad)
        {
            return Consultar().Where(r => r.Especializacion.Codigo.Equals(cualidad)).ToList();
        }
    }
}
