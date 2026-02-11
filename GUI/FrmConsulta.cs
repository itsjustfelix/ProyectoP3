using Entidad;
using Logica;
using ProyectoP3.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProyectoP3
{
    public partial class FrmConsulta : Form
    {
        ConsultaService consultaService;
        public FrmConsulta()
        {
            InitializeComponent();
            consultaService = new ConsultaService();
        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            cargarDGV(consultaService.Consultar());
        }
        private void abrirDocumento(string ruta)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = ruta,
                UseShellExecute = true
            });
        }
        private DialogResult dialogoPregunta(string accion)
        {
            return MessageBox.Show(
             $"¿Está seguro de que desea {accion}?",
             $"Confirmar {accion}",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question
             );
        }
        private bool eliminar(string codigo)
        {
            try
            {
                return consultaService.Borrar(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void mostrarFrm(Form frm)
        {
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }
        private ConsultaDTO buscar(string id)
        {
            return consultaService.buscar(id);
        }
        private void cargarDGV(List<ConsultaDTO> lista)
        {
            DGVConsulta.Rows.Clear();
            foreach (var consulta in lista)
            {
                DGVConsulta.Rows.Add(
                    consulta.Codigo,
                    consulta.NombreMascota,
                    consulta.Fecha,
                    consulta.NombreVeterinario,
                    consulta.Descripcion,
                    consulta.Diagnostico,
                    consulta.Tratamiento
                    );
            }
        }
        private async void DGVConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string codigo = DGVConsulta.CurrentRow.Cells["Codigo"].Value.ToString();
            if (DGVConsulta.Columns[e.ColumnIndex].Name == "Editar")
            {
                ConsultaDTO consulta = buscar(codigo);
                mostrarFrm(new FrmConsultaEditar(consulta));
                cargarDGV(consultaService.Consultar());
            }
            else if (DGVConsulta.Columns[e.ColumnIndex].Name == "elimina")
            {
                var respuesta = dialogoPregunta("eliminar");
                if (respuesta == DialogResult.Yes)
                {
                    eliminar(codigo);
                    MessageBox.Show("Veterinario eliminado correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDGV(consultaService.Consultar());
                }
            }
            else if (DGVConsulta.Columns[e.ColumnIndex].Name == "GenerarPDF")
            {
                ConsultaDTO consulta = buscar(codigo);
                string ruta = consultaService.GenerarDocumento(consulta, obtenerLogo());
                abrirDocumento(ruta);
            }
            else if (DGVConsulta.Columns[e.ColumnIndex].Name == "EnviarEmail")
            {
                MessageBox.Show("El email se está enviando en segundo plano. Puede continuar usando la aplicación.",
                               "Enviar Email", MessageBoxButtons.OK, MessageBoxIcon.Information);

                try
                {
                    await Task.Run(() =>
                    {
                        ConsultaDTO consulta = buscar(codigo);
                        string email = obtenerEmailPropietario(codigo);
                        string ruta = consultaService.GenerarDocumento(consulta, obtenerLogo());
                        consultaService.enviarEmail(email, ruta);
                    });

                    MessageBox.Show(
                        "Email enviado correctamente",
                        "Email Enviado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Error al enviar email: {ex.Message}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            else if (DGVConsulta.Columns[e.ColumnIndex].Name == "VerConsulta")
            {
                ConsultaDTO consulta = buscar(codigo);
                mostrarFrm(new FrmConsultaMostrar(consulta));
            }
        }
        private bool esFecha(string texto)
        {
            DateTime fecha;
            return DateTime.TryParseExact(
                texto,
                "dd/MM/yyyy",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None,
                out fecha
            );
        }

        private byte[] obtenerLogo()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                Resources.logo_proyecto.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }
        private string obtenerEmailPropietario(string codigo)
        {
            return consultaService.ObtenerEmailPropietaio(codigo);
        }
        private void txtFiltrarPorFecha_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtFiltrarPorFecha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var texto = txtFiltrarPorFecha.Text.Trim().ToLower();
                if (texto == "") cargarDGV(consultaService.Consultar());
                else if (esFecha(texto)) cargarDGV(consultaService.buscarPorFecha(texto));
                else if (texto.All(char.IsLetter)) cargarDGV(consultaService.buscarPorVeterinarioMascota(texto));
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
