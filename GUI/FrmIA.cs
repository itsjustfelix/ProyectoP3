using Modelo_IA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoP3
{
    private readonly AdministradorDeConversacion cm = new AdministradorDeConversacion();
    private readonly ServicioGeminis  _gemini = new ServicioGeminis();
    public partial class FrmIA : Form
    {
        public FrmIA()
        {
            InitializeComponent();
        }

        private void txtPregunta_TextChanged(object sender, EventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita salto de línea
                btnEnviar.PerformClick();
            }
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            string userInput = txtPregunta.Text.Trim();
            if (string.IsNullOrEmpty(userInput)) return;

            txtHistorial.AppendText($"Tú: {userInput}\n");
            txtPregunta.Clear();
            lblEstado.Text = "Consultando a la IA...";

            // Guardar mensaje del usuario
            cm.AddMessage(Role.User, userInput);

            try
            {
                var prompt = GenerarMensajes.BuildPrompt(cm.GetHistory(), userInput);
                var respuesta = await _gemini.GetResponseAsync(prompt);

                cm.AddMessage(Role.Assistant, respuesta);
                txtHistorial.AppendText($"IA: {respuesta}\n\n");
            }
            catch (Exception ex)
            {
                txtHistorial.AppendText($"[Error: {ex.Message}]\n");
            }

            lblEstado.Text = "Listo";
        }

    }
}

