using Modelo_IA;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoP3
{
    public partial class FrmIA : Form
    {
        private readonly AdministradorDeConversacion cm = new AdministradorDeConversacion();
        private readonly ServicioGeminis _gemini = new ServicioGeminis();
        private List<Mensaje> prompt;

        public FrmIA() 
        {
            InitializeComponent();
        }
           
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                // Mostrar que está procesando
                lblEstado.Text = "Consultando a la IA...";
                lblEstado.Visible = true;

                // Captura el texto del usuario
                string textoUsuario = txtPregunta.Text.Trim();

                if (string.IsNullOrWhiteSpace(textoUsuario))
                {
                    lblEstado.Text = "Por favor escribe una pregunta.";
                    return;
                }

                // Agrega el mensaje del usuario a la lista de mensajes
                object mensajeUsuario = GetMensajeUsuario(textoUsuario);

                // 🔹 Espera la respuesta del servicio (bloqueante, SIN async)
                string respuesta = _gemini.GetResponse(prompt);

                // Muestra la respuesta en el historial
                txtHistorial.AppendText($"Tú: {textoUsuario}\r\n");
                txtHistorial.AppendText($"IA: {respuesta}\r\n\r\n");

                // Agrega el mensaje del modelo al historial
                object mensajeIA = GetMensajeIA(respuesta);

                // Actualiza el estado
                lblEstado.Text = "Respuesta recibida ✔";
                txtPregunta.Clear();
            }
            catch (Exception ex)
            {
                lblEstado.Text = "Error: " + ex.Message;
            }

        }
        private Mensaje GetMensajeIA(string respuesta)
        {
            var mensaje = new Mensaje
            {
                Role = role.Assistant,
                Content = respuesta
            };
            
            return mensaje;
        }

        private Mensaje GetMensajeUsuario(string textoUsuario)
        {
            var mensaje = new Mensaje
            {
                Role = role.User,
                Content = textoUsuario
            };
            return mensaje;
        }

        private void txtPregunta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita salto de línea
                btnEnviar.PerformClick();
            }

        }
    }
}

