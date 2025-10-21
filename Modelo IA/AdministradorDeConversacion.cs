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

        private readonly List<Mensaje> _messages = new List<Mensaje>();

        public void AddMessage(Role role, string content)
        {
            _messages.Add(new Mensaje { Role = role, Content = content });
        }

        public List<Mensaje> GetHistory(int limit = 20)
        {
            // Devuelve los últimos 20 mensajes (ajustable)
            return _messages.Skip(Math.Max(0, _messages.Count - limit)).ToList();
        }

        public void ClearHistory()
        {
            _messages.Clear();
        }


    }
}
