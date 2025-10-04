using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Logica;
using Microsoft.VisualBasic;

namespace ProyectoP3
{
    public partial class FrmCita : Form
    {
        IServiceEntidad<Cita> logCita = new LogCita();
        public FrmCita()
        {
            InitializeComponent();
        }
        private void FrmCita_Load(object sender, EventArgs e)
        {
            cargarDGV();
        }
        private void cargarDGV()
        {
            DGVCita.Rows.Clear();
            foreach (Cita cita in logCita.Consultar())
            {
                DGVCita.Rows.Add(cita.id, cita.fecha.ToString("dd/MM/yyyy"), cita.hora.ToString("HH:mm tt"), cita.mascota.nombre);
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            mostrarFrm(new FrmCitaAgregar());
            cargarDGV();
        }
        private Cita buscarCita(int id)
        {
            return logCita.Consultar().FirstOrDefault(c => c.id == id);
            //TODO:esto no debe de ir aqui, debe ir en logica
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(Interaction.InputBox("Ingrese el codigo de la cita a buscar:", "Buscar cita", ""));
                Cita cita = buscarCita(id);
                if (cita == null)
                {
                    MessageBox.Show("Cita no encontrada.", "Buscar Cita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                mostrarFrm(new FrmcitaEditar(cita));
                cargarDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(Interaction.InputBox("Ingrese el codigo de la cita a eliminar:", "Eliminar cita", ""));
                if (buscarCita(id) == null)
                {
                    MessageBox.Show("Cita no encontrada.", "Buscar Cita", MessageBoxButtons.OK, MessageBoxIcon.Information  );
                    return;
                }
                DialogResult result = dialogoPregunta("eliminar la cita");
                if (result == DialogResult.No || result == DialogResult.None)
                {
                    MessageBox.Show("Operación cancelada.", "Eliminar Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string message = borrarCita(id);
                MessageBox.Show(message, "Eliminar Cita", MessageBoxButtons.OK, MessageBoxIcon.Information                                      );
                cargarDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private string borrarCita(int codigoCita)
        {
            try
            {
                return logCita.Borrar(codigoCita);
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
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(Interaction.InputBox("Ingrese el ID de la cita a buscar:", "Buscar cita", ""));
                Cita cita = buscarCita(id);
                if (cita == null)
                {
                    MessageBox.Show("Cita no encontrada.", "Buscar Cita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                ocultar();
                mostrarFrm(new FrmConsultaAgregar(cita.mascota));
                mostrar();
                borrarCita(id);
                cargarDGV();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void mostrar()
        {
            this.Show();
        }
        private void mostrarFrm(Form frm)
        {
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }
        private void ocultar()
        {
            this.Hide();
        }
    }
}
