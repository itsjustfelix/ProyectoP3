using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entidad;
using Logica;
using Microsoft.VisualBasic;

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
        private Cita buscarCita(int id)
        {
            return CitaService.BuscarPorId(id);
        }
        private void bttnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string input = Interaction.InputBox(
                    "Ingrese el código de la cita a buscar:",
                    "Buscar Cita", ""
                );

                if (string.IsNullOrWhiteSpace(input))
                    return;

                if (!int.TryParse(input, out int id))
                {
                    MessageBox.Show("Debe ingresar un número válido.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Cita cita = buscarCita(id);
                if (cita == null)
                {
                    MessageBox.Show("Cita no encontrada.", "Buscar Cita",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                mostrarFrm(new FrmcitaEditar(cita));
                cargarDGV(CitaService.Consultar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string input = Interaction.InputBox("Ingrese el código de la cita a eliminar:", "Eliminar Cita", "");
                if (string.IsNullOrWhiteSpace(input)) return;
                if (!int.TryParse(input, out int id))
                {
                    MessageBox.Show("Debe ingresar un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (buscarCita(id) == null)
                {
                    MessageBox.Show("Cita no encontrada.", "Eliminar Cita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (dialogoPregunta("eliminar la cita") != DialogResult.Yes) return;

                borrarCita(id);
                MessageBox.Show("Cita eliminada correctamente.", "Eliminar Cita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarDGV(CitaService.Consultar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void bttnAtenderCita_Click(object sender, EventArgs e)
        {
            try
            {
                string input = Interaction.InputBox("Ingrese el código de la cita a buscar:", "Buscar Cita", "");
                if (string.IsNullOrWhiteSpace(input)) return;
                if (!int.TryParse(input, out int id))
                {
                    MessageBox.Show("Debe ingresar un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Cita cita = buscarCita(id);
                if (cita == null)
                {
                    MessageBox.Show("Cita no encontrada.", "Buscar Cita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var frm = new FrmConsultaAgregar(cita.Mascota, cita.Veterinario);
                mostrarFrm(frm);

                if (frm.resultado == DialogResult.OK)
                {
                    borrarCita(id);
                    cargarDGV(CitaService.Consultar());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            if(txtFiltrarPorFacha.Text.Trim() == "")
            {
                cargarDGV(CitaService.Consultar());
                return;
            }
            else
            {
               cargarDGV(CitaService.buscarPorFecha(txtFiltrarPorFacha.Text.Trim()));
            }
        }
    }
}
