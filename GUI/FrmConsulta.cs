using System;
using System.Collections.Generic;
using System.Linq;
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
        private void abrirDocumento(string ruta)
        {
            System.Diagnostics.Process.Start(ruta);
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
        private bool eliminar(int codigo)
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
        private Consulta buscar(int id)
        {
            return consultaService.buscar(id);
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
            int codigo = int.Parse(DGVConsulta.CurrentRow.Cells["Codigo"].Value.ToString());
            if (DGVConsulta.Columns[e.ColumnIndex].Name == "Editar")
            {
                Consulta consulta = buscar(codigo);
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
                Consulta consulta = buscar(codigo);
                string ruta = consultaService.GenerarDocumento(consulta);
                abrirDocumento(ruta);
            }
            else if (DGVConsulta.Columns[e.ColumnIndex].Name == "EnviarEmail")
            {
                Consulta consulta = buscar(codigo);
                string email = consulta.Mascota.Propietario.Email;
                string ruta = consultaService.GenerarDocumento(consulta);
                string mensaje = consultaService.enviarEmail(email, ruta);
                MessageBox.Show(mensaje, "Enviar Email",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (DGVConsulta.Columns[e.ColumnIndex].Name == "VerConsulta")
            {
                Consulta consulta = buscar(codigo);
                mostrarFrm(new FrmConsultaMostrar(consulta));
            }
        }
        private void bttnFiltrarPorFecha_Click(object sender, EventArgs e)
        {
            var texto = txtFiltrarPorFecha.Text.Trim().ToLower();
            if (texto == "")
            {
                cargarDGV(consultaService.Consultar());
                return;
            }
            else if (esFecha(texto))
            {
                cargarDGV(consultaService.buscarPorFecha(texto));
                return;
            }
            else if (texto.All(char.IsLetter))
            {
                cargarDGV(consultaService.buscarPorVeterinarioMascota(texto));
                return;
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

        private void txtFiltrarPorFecha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
