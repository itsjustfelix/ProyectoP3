using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entidad;
using Logica;
using Microsoft.VisualBasic;


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
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
                try
                {
                    string input = Interaction.InputBox(
                        "Ingrese el código de la consulta a eliminar:",
                        "Eliminar Consulta", ""
                    );
                    if (string.IsNullOrWhiteSpace(input)) return;
                    if (!int.TryParse(input, out int id))
                    {
                        MessageBox.Show("Debe ingresar un número válido.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    var consulta = buscarConsulta(id);
                    if (consulta == null)
                    {
                        MessageBox.Show("Consulta no encontrada.", "Eliminar Consulta",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (dialogoPregunta("eliminar la consulta") == DialogResult.No) return;
                    if (borrar(id))
                    {
                        MessageBox.Show("Consulta eliminada correctamente.", "Eliminar Consulta",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarDGV(consultaService.Consultar());
                    }
                    else
                        MessageBox.Show("No se pudo eliminar la consulta correctamente.", "Eliminar Consulta",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mostrarFrm(new FrmConsultaAgregar());
            cargarDGV(consultaService.Consultar());
        }
        private void bttnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(Interaction.InputBox("Ingrese el ID de la consulta a buscar:", "Buscar Consulta", ""));
                Consulta consulta = buscarConsulta(id);
                if (consulta == null)
                {
                    MessageBox.Show("Consulta no encontrada.", "Buscar Consulta",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                mostrarFrm(new FrmConsultaEditar(consulta));
                cargarDGV(consultaService.Consultar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void btnCrearPDF_Click_1(object sender, EventArgs e)
        {
            try
            {
                string input = Interaction.InputBox(
                    "Ingrese el código de la consulta que quiere hacerle PDF:",
                    "Generar PDF", ""
                );
                if (string.IsNullOrWhiteSpace(input)) return;
                if (!int.TryParse(input, out int id))
                {
                    MessageBox.Show("Debe ingresar un número válido.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var consulta = buscarConsulta(id);
                if (consulta == null)
                {
                    MessageBox.Show("Consulta no encontrada.", "Generar PDF",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string ruta = consultaService.GenerarDocumento(consulta);
                abrirDocumento(ruta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void abrirDocumento(string ruta)
        {
            System.Diagnostics.Process.Start(ruta);
        }
        private void bttnCrearPDFEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                string input = Interaction.InputBox(
                    "Ingrese el código de la consulta que quiere mandar por email:",
                    "Mandar consulta por email", ""
                );
                if (string.IsNullOrWhiteSpace(input)) return;
                if (!int.TryParse(input, out int codigo))
                {
                    MessageBox.Show("El código debe ser un número.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var consulta = buscarConsulta(codigo);
                if (consulta == null)
                {
                    MessageBox.Show("Consulta no encontrada.", "Buscar Consulta",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string email = consulta.Mascota.Propietario.Email;
                string ruta = consultaService.GenerarDocumento(consulta);
                string mensaje = consultaService.enviarEmail(email, ruta);
                MessageBox.Show(mensaje, "Enviar Email",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        private bool borrar(int codigo)
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
        private Consulta buscarConsulta(int id)
        {
            return consultaService.BuscarPorId(id);
        }
        private void cargarDGV(List<Consulta> lista)
        {
            DGVConsulta.Rows.Clear();
            foreach (var consulta in lista)
            {
                DGVConsulta.Rows.Add(
                    consulta.Codigo,
                    consulta.Mascota.Nombre,
                    consulta.Fecha,
                    consulta.Veterinario.Nombres,
                    consulta.Descripcion,
                    consulta.Diagnostico,
                    consulta.Tratamiento
                    );
            }
        }
        private void DGVConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (txtFiltrarPorVeterinario.Text.Trim() == "")
            {
                cargarDGV(consultaService.Consultar());
                return;
            }
            else
            {
                cargarDGV(consultaService.buscarPorVeterinario(txtFiltrarPorVeterinario.Text.Trim()));
            }
        }
        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void bttnFiltrarPorFecha_Click(object sender, EventArgs e)
        {
            if (txtFiltrarPorFecha.Text.Trim() == "")
            {
                cargarDGV(consultaService.Consultar());
                return;
            }
            else
            {
                cargarDGV(consultaService.buscarPorFecha(txtFiltrarPorFecha.Text.Trim()));
            }
        }
        private void bttnFiltrarPorMascota_Click(object sender, EventArgs e)
        {
            if (txtFiltrarPorMascota.Text.Trim() == "")
            {
                cargarDGV(consultaService.Consultar());
                return;
            }
            else
            {
                cargarDGV(consultaService.buscarPorMascota(txtFiltrarPorMascota.Text.Trim()));
            }
        }
    }
}
