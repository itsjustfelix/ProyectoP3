using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Entidad;
using Microsoft.VisualBasic;
using System.Net;

namespace ProyectoP3
{
    public partial class FrmConsulta : Form
    {
        public FrmConsulta()
        {
            InitializeComponent();
        }
        LogConsulta logConsulta = new LogConsulta();
        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            cargarDGV();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            mostrarFrm(new FrmConsultaAgregar());
            cargarDGV();
        }

        private void cargarDGV()
        {
            DGVConsulta.Rows.Clear();
            foreach (var consulta in logConsulta.Consultar())
            {
                DGVConsulta.Rows.Add(consulta.id, consulta.mascota.nombre,consulta.fecha.ToString("dd/MM/yyyy"), consulta.veterinario.Nombre,  consulta.diagnostico, consulta.tratamiento);
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
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

        private Consulta buscarConsulta(int id)
        {
            return logConsulta.BuscarPorId(id);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
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
                if (confirmacion == DialogResult.No || confirmacion == DialogResult.None)
                {
                    MessageBox.Show("Operación cancelada.", "Eliminar Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string message = borrar(id);
                MessageBox.Show(message, "Eliminar Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string borrar(int codigo)
        {
            try
            {
                return logConsulta.Borrar(codigo);
            }
            catch (Exception ex)
            { 
                return ex.Message;
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

        private void mostrarFrm(Form frm)
        {
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void DGVConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
