using System;
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
            cargarDGV();
        }
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(Interaction.InputBox("Ingrese el codigo de la consulta a eliminar:", "Eliminar Consulta", ""));
                if (buscarConsulta(id) == null)
                {
                    MessageBox.Show("Consulta no encontrada.", "Eliminar Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                var confirmacion = dialogoPregunta("eliminar la consulta");
                if (confirmacion == DialogResult.Yes)
                {
                    borrar(id);
                    MessageBox.Show("Operación cancelada.", "Eliminar Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDGV();
                    return;
                }
                else return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mostrarFrm(new FrmConsultaAgregar());
            cargarDGV();
        }
        private void bttnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(Interaction.InputBox("Ingrese el ID de la consulta a buscar:", "Buscar Consulta", ""));
                Consulta consulta = buscarConsulta(id);
                if (consulta == null)
                {
                    MessageBox.Show("Consulta no encontrada.", "Buscar Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                mostrarFrm(new FrmConsultaEditar(consulta));
                cargarDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void btnCrearPDF_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(Interaction.InputBox("Ingrese el codigo de la consulta que quiere hacerle PDF:", "Generar PDF", ""));
                var consulta = buscarConsulta(id);
                if (consulta == null)
                {
                    MessageBox.Show("Consulta no encontrada.", "Eliminar Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                var ruta = consultaService.GenerarDocumento(consulta);
                MessageBox.Show($"Documento generado en: {ruta}", "Generar PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void bttnCrearPDFEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(Interaction.InputBox("Ingrese el codigo de la consulta que quiere hacerle PDF:", "Generar PDF", ""));
                var consulta = buscarConsulta(id);
                var email = consulta.Mascota.Propietario.Email;
                if (consulta == null)
                {
                    MessageBox.Show("Consulta no encontrada.", "Eliminar Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                var ruta = consultaService.GenerarDocumento(consulta);
                var mensaje = consultaService.enviarEmail(email, ruta);
                MessageBox.Show(mensaje, "Enviar Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void cargarDGV()
        {
            DGVConsulta.Rows.Clear();
            foreach (var consulta in consultaService.Consultar())
            {
                DGVConsulta.Rows.Add(
                    consulta.Codigo,
                    consulta.Mascota.Nombre,
                    consulta.Fecha.ToString("dd/MM/yyyy"),
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
    }
}
