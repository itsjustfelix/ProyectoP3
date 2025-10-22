using Modelo_IA;
using System;
using System.Windows.Forms;

namespace ProyectoP3
{
    public partial class FrmIA : Form
    {
        private readonly AdministradorDeConversacion cm = new AdministradorDeConversacion();
        private readonly ServicioGeminis _gemini = new ServicioGeminis();

        public FrmIA()
        {
            InitializeComponent();
        }
           
        private  void btnEnviar_Click(object sender, EventArgs e)
        {
            string userInput = txtPregunta.Text.Trim();
            if (string.IsNullOrEmpty(userInput)) return;

            txtHistorial.AppendText($"Tú: {userInput}\n");
            txtPregunta.Clear();
            lblEstado.Text = "Consultando a la IA...";

            // Guardar mensaje del usuario
            cm.AddMensaje(Role.User, userInput);

            try
            {
                var prompt = GenerarMensajes.BuildPrompt(cm.GetHistory(), userInput);
                var respuesta = _gemini.GetResponse(prompt);

                cm.AddMensaje(Role.Assistant, respuesta);
                txtHistorial.AppendText($"IA: {respuesta}\n\n");
            }
            catch (Exception ex)
            {
                txtHistorial.AppendText($"[Error: {ex.Message}]\n");
            }

            lblEstado.Text = "Listo";
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

