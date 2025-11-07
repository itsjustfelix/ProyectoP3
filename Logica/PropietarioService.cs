using System;
using System.Collections.Generic;
using System.Linq;
using Dato;
using Entidad;

namespace Logica
{
    public class PropietarioService : ICrud<Propietario>, IIDUnico
    {
        private readonly IRepository<Propietario> datoPropietario;
        public PropietarioService()
        {
            datoPropietario = new DatoPropietario();
        }
        public string Guardar(Propietario entidad)
        {
            try
            {
                string mensaje = string.Empty;
                if (Validar(entidad, out mensaje) && IdUnico(entidad.Cedula)) 
                    mensaje = datoPropietario.Guardar(entidad);
                return mensaje;
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }
        public List<Propietario> Consultar()
        {
            return datoPropietario.Consultar();
        }
        public string Actualizar(Propietario NuevaEntidad)
        {
            try
            {
                string mensaje;
                if (Validar(NuevaEntidad, out mensaje))
                 mensaje = datoPropietario.Actualizar(NuevaEntidad);
                return mensaje;
            }
            catch (Exception e)
            {
                return e.Message;
            }


        }
        public string Borrar(int Id) 
        {
            try
            {
                return datoPropietario.Eliminar(Id);
            }
            catch (Exception ex)
            {
               return ex.Message;
            }
           
        }
        public Propietario BuscarPorId(int id)
        {
            return datoPropietario.BuscarPorId(id);
        }
        public bool Validar(Propietario entidad, out string mensaje)
        {
            mensaje = string.Empty;
            if (entidad == null)
            {
                mensaje = "Propietario nulo";
                return false;
            }
            if (entidad.Nombres.Any(char.IsDigit))
            {
                mensaje = "El nombre no puede contener numeros";
                return false;
            } 
            if (entidad.ApellidoPaterno.Any(char.IsDigit))
            {
                mensaje = "El apellido paterno no puede contener numeros";
                return false;
            }
            if (entidad.ApellidoMaterno.Any(char.IsDigit))
            {
                mensaje = "El apellido materno no puede contener numeros";
                return false;
            }
            if (entidad.Cedula.ToString().Length < 8 || entidad.Cedula.ToString().Length > 10)
            {
                mensaje = "El ID debe tener entre 8 y 10 digitos";
                return false;
            }
            if (entidad.Cedula.ToString().Any(char.IsLetter))
            {
                mensaje = "La cedula no puede contener letras";
                return false;
            }
            if (entidad.Telefono.Any(char.IsLetter))
            {
                mensaje = "El telefono primario no puede contener letras";
                return false;
            }
            if (entidad.Telefono.Length != 10)
            {
                mensaje = "El telefono primario debe tener 10 digitos";
                return false;
            }
            if(entidad.Email.AsParallel().Count(c => c == '@') != 1 || entidad.Email.StartsWith("@") || entidad.Email.EndsWith("@"))
            {
                mensaje = "El correo electronico debe contener un solo @ y no puede estar al inicio o al final";
                return false;
            }
            return true;
        }
        public bool IdUnico(int id)
        {
            if (BuscarPorId(id) != null) throw new ArgumentException("La Cedula ya esta registrada en la base de datos");
            return true;
        }

    }
}
