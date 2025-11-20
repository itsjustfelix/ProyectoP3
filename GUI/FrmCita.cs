using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace ProyectoP3
{
    public partial class FrmCita : Form
    {
        CitaService CitaService;
        public FrmCita()
        {
            InitializeComponent();
            CitaService = new CitaService();
        }
        private void FrmCita_Load(object sender, EventArgs e)
        {
            cargarDGV(CitaService.Consultar());
        }
        private void cargarDGV(List<Cita> lista)
        {
            DGVCita.Rows.Clear();
            foreach (Cita item in lista)
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
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mostrarFrm(new FrmCitaAgregar());
            cargarDGV(CitaService.Consultar());
        }
        private Cita buscar(int id)
        {
            return CitaService.buscar(id);
        }

        private bool eliminar(int codigoCita)
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

        private void mostrarFrm(Form frm)
        {
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void bttnFiltrarPorVeterinario_Click(object sender, EventArgs e)
        {
            if (txtFiltrarPorVeterinario.Text.Trim() == "")
            {
                cargarDGV(CitaService.Consultar());
                return;
            }
            else
            {
                cargarDGV(CitaService.buscarPorVeterinario(txtFiltrarPorVeterinario.Text));
            }
        }

        private void bttnFiltrarPorFecha_Click(object sender, EventArgs e)
        {
            if (txtFiltrarPorFacha.Text.Trim() == "")
            {
                cargarDGV(CitaService.Consultar());
                return;
            }
            else
            {
                cargarDGV(CitaService.buscarPorFecha(txtFiltrarPorFacha.Text.Trim()));
            }
        }

        private void DGVCita_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int codigo = int.Parse(DGVCita.CurrentRow.Cells["Codigo"].Value.ToString());
            if (DGVCita.Columns[e.ColumnIndex].Name == "Editar")
            {
                Cita cita = buscar(codigo);
                mostrarFrm(new FrmcitaEditar(cita));
                cargarDGV(CitaService.Consultar());
            }
            else if (DGVCita.Columns[e.ColumnIndex].Name == "elimina")
            {
                var respuesta = dialogoPregunta("eliminar");
                if (respuesta == DialogResult.Yes)
                {
                    eliminar(codigo);
                    MessageBox.Show("Veterinario eliminado correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDGV(CitaService.Consultar());
                }
            }
            else if (DGVCita.Columns[e.ColumnIndex].Name == "AtenderCita")
            {
                Cita cita = buscar(codigo);
                if (cita.Fecha.Equals(DateTime.Now.ToString("dd/MM/yyyy")))
                {
                    var frm = new FrmConsultaAgregar(cita.Mascota, cita.Veterinario);
                    mostrarFrm(frm);

                    if (frm.resultado == DialogResult.OK)
                    {
                        eliminar(codigo);
                        cargarDGV(CitaService.Consultar());
                    }
                }
                else
                    MessageBox.Show("La fecha de la cita no esta para hoy.", "Atender cita.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
