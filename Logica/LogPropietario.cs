using System;
using System.Collections.Generic;
using System.Linq;
using Dato;
using Entidad;

namespace Logica
{
    public class LogPropietario : IService<Propietario>, IIdUnico
    {
        private readonly DatoPropietario datoPropietario = new DatoPropietario(NombreArchivo.ARCHIVO_PROPIETARIO);
        public string Guardar(Propietario entidad)
        {
            try
            {
                string mensaje = string.Empty;
                if (Validar(entidad, out mensaje) && IdUnico(entidad.Cedula)) mensaje = datoPropietario.Guardar(entidad);
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
                {
                    var listaPropietario = Consultar();
                    int index = listaPropietario.FindIndex(p => p.Cedula == NuevaEntidad.Cedula);
                    if (index == -1) throw new KeyNotFoundException("Propietario no encontrado");
                    listaPropietario[index] = NuevaEntidad;
                    mensaje = datoPropietario.SobrescribirArchivo(listaPropietario);
                }
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
                var listaPropietario = Consultar();
                int index = listaPropietario.FindIndex(p => p.Cedula == Id);
                if (index == -1) throw new KeyNotFoundException("Propietario no encontrado");
                listaPropietario.RemoveAt(index);
                datoPropietario.SobrescribirArchivo(listaPropietario);
                return "Propietario borrado correctamente";
            }
            catch (Exception ex)
            {
               return ex.Message;
            }
           
        }
        public Propietario BuscarPorId(int id)
        {
            return Consultar().FirstOrDefault(p => p.Cedula == id);
        }
        public bool Validar(Propietario entidad, out string mensaje)
        {
            mensaje = string.Empty;
            if (entidad == null)
            {
                mensaje = "Propietario nulo";
                return false;
            }
            if (string.IsNullOrEmpty(entidad.Nombre))
            {
                mensaje = "El nombre es obligatorio";
                return false;
            }
            if(entidad.Nombre.All(char.IsDigit))
            {
                mensaje = "El nombre no puede contener numeros";
                return false;
            }
            if (string.IsNullOrEmpty(entidad.Sexo))
            {
                mensaje = "El sexo es obligatorio";
                return false;
            }
            if (string.IsNullOrEmpty(entidad.Telefono))
            {
                mensaje = "El telefono es obligatorio";
                return false;
            }
            if (entidad.Cedula.ToString().Length < 8 || entidad.Cedula.ToString().Length > 10)
            {
                mensaje = "El ID debe tener entre 8 y 10 digitos";
                return false;
            }
            if (entidad.Telefono.Length != 10)
            {
                mensaje = "El telefono debe tener 10 digitos";
                return false;
            }
            if (entidad.Telefono.All(char.IsLetter))
            {
                mensaje = "El telefono no puede contener letras";
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
