using Microsoft.VisualBasic;
using Modelo_IA;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoP3
{
    public partial class FrmIA : Form
    {
        private readonly AdministradorDeConversacion cm = new AdministradorDeConversacion();
        private readonly ServicioIA _gemini = new ServicioIA();
        private readonly List<Mensaje> prompt = new List<Mensaje>();

        public FrmIA() 
        {
            InitializeComponent();
        }
       

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                lblEstado.Text = "Consultando a la IA...";
                lblEstado.Visible = true;

                string textoUsuario = txtPregunta.Text.Trim();
                if (string.IsNullOrWhiteSpace(textoUsuario))
                {
                    lblEstado.Text = "Por favor escribe una pregunta.";
                    return;
                }

                // Agregar mensaje del usuario
                var mensajeUsuario = GetMensajeUsuario(textoUsuario);
                prompt.Add(mensajeUsuario);

                txtHistorial.AppendText($"Tú: {textoUsuario}\r\n");

                // ✅ Llamada asíncrona
                string respuesta = await _gemini.GetResponseAsync(prompt);

                txtHistorial.AppendText($"IA: {respuesta}\r\n\r\n");

                // Agregar mensaje de la IA
                var mensajeIA = GetMensajeIA(respuesta);
                prompt.Add(mensajeIA);

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
                Role = role.Model,
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

