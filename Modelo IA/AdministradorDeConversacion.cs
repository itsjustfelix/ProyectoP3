using System;
using GenerativeAI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_IA
{
    public class AdministradorDeConversacion
    {

        private readonly List<Mensaje> _mensaje = new List<Mensaje>();

        public void AddMensaje(Role role, string content)
        {
            _mensaje.Add(item: new Mensaje { Role = role, Content = content });
        }

        public List<Mensaje> GetHistory(int limit = 20) =>
            // Devuelve los últimos 20 mensajes (ajustable)
            _mensaje.Skip(Math.Max(0, _mensaje.Count - limit)).ToList();

        public void ClearHistory()
        {
            _mensaje.Clear();
        }


    }
}
