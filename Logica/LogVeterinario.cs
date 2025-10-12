using System;
using System.Collections.Generic;
using System.Linq;
using Dato;
using Entidad;
namespace Logica
{
    public class LogVeterinario : IServicePersonas<Veterinario>
    {
        private readonly DatoVeterinario datoVeterinario = new DatoVeterinario(NombreArchivo.ARC_VETERINARIO);
        public string Guardar(Veterinario entidad)
        {
            try
            {
                string mensaje = string.Empty;
                if (Validar(entidad, out mensaje) && IdUnico(entidad.Cedula)) mensaje = datoVeterinario.Guardar(entidad);
                return mensaje;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        public List<Veterinario> Consultar()
        {
            return datoVeterinario.Consultar();
        }
        public string Actualizar(Veterinario NuevaEntidad)
        {
            try
            {
                string mensaje = string.Empty;
                if (Validar(NuevaEntidad, out mensaje))
                {
                    var listaVeterinario = Consultar();
                    int index = listaVeterinario.FindIndex(v => v.Cedula == NuevaEntidad.Cedula);
                    if (index == -1) throw new KeyNotFoundException("Veterinario no encontrado para actualizar.");
                    listaVeterinario[index] = NuevaEntidad;
                    mensaje = datoVeterinario.SobrescribirArchivo(listaVeterinario);
                }
                return mensaje;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Borrar(int id)
        {
            var listaVeterinario = Consultar();
            int index = listaVeterinario.FindIndex(v => v.Cedula == id);
            if (index == -1) throw new KeyNotFoundException("Veterinario no encontrado para borrar.");
            listaVeterinario.RemoveAt(index);
            return datoVeterinario.SobrescribirArchivo(listaVeterinario);
        }
        public Veterinario BuscarPorId(int id)
        {
            return datoVeterinario.BuscarPorId(id);
        }
        public bool Validar(Veterinario entidad,out string mensaje)
        {
            mensaje = string.Empty;
            if (entidad == null)
            {
                mensaje = "Propietario nulo";
                return false;
            }
            if(entidad.Especializacion == null)
            {
                mensaje = "La especializacion no puede ser nula";
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
            if (entidad.TelefonoPrimario.Any(char.IsLetter))
            {
                mensaje = "El telefono primario no puede contener letras";
                return false;
            }
            if (entidad.TelefonoSecundario.Any(char.IsLetter))
            {
                mensaje = "El telefono secundario no puede contener letras";
                return false;
            }
            if (entidad.TelefonoPrimario.Length != 10)
            {
                mensaje = "El telefono primario debe tener 10 digitos";
                return false;
            }
            if (entidad.TelefonoSecundario.Length != 10)
            {
                mensaje = "El telefono secundario debe tener 10 digitos";
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
