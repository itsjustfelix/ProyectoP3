using System;
using System.Windows.Forms;
using Entidad;
using Logica;
using Microsoft.VisualBasic;

namespace ProyectoP3
{
    public partial class FrmCita : Form
    {
        ICrud<Cita> CitaService;
        public FrmCita()
        {
            InitializeComponent();
            CitaService = new CitaService();
        }
        private void FrmCita_Load(object sender, EventArgs e)
        {
            cargarDGV();
        }
        private void cargarDGV()
        {
            DGVCita.Rows.Clear();
            foreach (Cita item in CitaService.Consultar())
            {
                DGVCita.Rows.Add(
                    item.Codigo,
                    item.Fecha,
                    item.Hora,
                    item.Mascota.Nombre,
                    item.Veterinario.Nombres
                    );
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            mostrarFrm(new FrmCitaAgregar());
            cargarDGV();
        }
        private Cita buscarCita(int id)
        {
            return CitaService.BuscarPorId(id);
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
                int id =int.Parse(Interaction.InputBox("Ingrese el codigo de la cita a eliminar:", "Eliminar cita", ""));
                if (buscarCita(id) == null)
                {
                    MessageBox.Show("Cita no encontrada.", "Buscar Cita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DialogResult result = dialogoPregunta("eliminar la cita");
                if (result == DialogResult.Yes)
                {
                    borrarCita(id);
                    MessageBox.Show("Cita eliminada correctamente.", "Eliminar Cita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDGV();
                    return;
                }
                else
                    return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool borrarCita(int codigoCita)
        {
            try
            {
                return CitaService.Borrar(codigoCita);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar cita: {ex.Message}", ex);
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
                var frm = new FrmConsultaAgregar(cita.Mascota,cita.Veterinario);
                mostrarFrm(frm);
                if (frm.resultado == DialogResult.OK)
                {
                    borrarCita(id);
                    cargarDGV();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void mostrarFrm(Form frm)
        {
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }
    }
}
