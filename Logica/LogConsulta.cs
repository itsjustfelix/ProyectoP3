using System;
using System.Collections.Generic;
using System.Linq;
using Dato;
using Entidad;

namespace Logica
{
    public class LogConsulta : IServiceEntidad<Consulta>
    {
        private readonly DatoConsulta datoConsulta = new DatoConsulta(NombreArchivo.ARCHIVO_CONSULTA);
        private Random random = new Random();
        public string Guardar(Consulta entidad)
        {
            try
            {
                string mensaje = string.Empty;
                if (Validar(entidad, out mensaje))
                {
                    entidad.Codigo = GenerarIdUnico();
                    mensaje = datoConsulta.Guardar(entidad);

                }
                return mensaje;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<Consulta> Consultar()
        {
            return datoConsulta.Consultar();
        }
        public string Actualizar(Consulta NuevaEntidad)
        {
            try
            {
                string mensaje = string.Empty;
                if (Validar(NuevaEntidad, out mensaje))
                {
                    var listaConsultas = Consultar();
                    int index = listaConsultas.FindIndex(c => c.Codigo == NuevaEntidad.Codigo);
                    if (index == -1) throw new KeyNotFoundException("Consulta no encontrada");
                    listaConsultas[index] = NuevaEntidad;
                    mensaje = datoConsulta.SobrescribirArchivo(listaConsultas);
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
            var listaConsultas = Consultar();
            int index = listaConsultas.FindIndex(c => c.Codigo == id);
            if (index == -1) throw new KeyNotFoundException("Consulta no encontrada");
            listaConsultas.RemoveAt(index);
            return datoConsulta.SobrescribirArchivo(listaConsultas);
        }
        public int GenerarIdUnico()
        {
            int id;
            List<Consulta> consultasExistentes = Consultar();
            HashSet<int> idsExistentes = new HashSet<int>(consultasExistentes.Select(m => m.Codigo));
            do
            {
                id = random.Next(1000, 10000);
            }
            while (idsExistentes.Contains(id));
            return id;
        }
        public Consulta BuscarPorId(int id)
        {
            return Consultar().FirstOrDefault(c => c.Codigo == id);
        }
        public bool Validar(Consulta entidad, out string mensaje)
        {
            mensaje = string.Empty;
            if (entidad == null)
            {
                mensaje = "La entidad no puede ser nula.";
                return false;
            }
            if (entidad.Mascota == null)
            {
                mensaje = "La mascota no puede ser nula.";
                return false;
            }
            if (entidad.Veterinario == null)
            {
                mensaje = "El veterinario no puede ser nulo.";
                return false;
            }
            if (entidad.Fecha == default)
            {
                mensaje = "La fecha no puede ser vacia.";
                return false;
            }
            if (entidad.Diagnostico.Length == 0)
            {
                mensaje = "El diagnostico debe ser rellenado";
                return false;
            }
            if (entidad.Tratamiento.Length == 0)
            {
                mensaje = "El tratamiento debe ser rellenado";
                return false;
            }
            return true;
        }
    }
}
