using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace ProyectoP3
{
    public partial class FrmEstadistica : Form
    {
        CitaService citaService;
        VeterinarioService veterinarioService;
        MascotaService mascotaService;
        ConsultaService consultaService;

        public FrmEstadistica()
        {
            InitializeComponent();
            this.monthCalendar1.DateSelected += MonthCalendar1_DateSelected;
            citaService = new CitaService();
            veterinarioService = new VeterinarioService();
            mascotaService = new MascotaService();
            consultaService = new ConsultaService();
        }

        private void MonthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            CargarCitasDelDia(e.Start);
        }

        private void CargarCitasDelDia(DateTime fecha)
        {
            dgvCitasHoy.Rows.Clear();
            var citas = citaService.buscarPorFecha(fecha.ToString("dd/MM/yyyy"));
            if (citas != null && citas.Count > 0)
            {
                foreach (var c in citas)
                {
                   dgvCitasHoy.Rows.Add(c.Codigo, c.Mascota.Nombre, c.Veterinario.Nombres, c.Fecha, c.Hora);
                }
            }
               
        }

        private void cargarDiagrama(List<citasPorFechas> lista)
        {
            try
            {
                gunaChart1.Datasets.Clear();
                var barDataset = new Guna.Charts.WinForms.GunaBarDataset
                {
                    Label = "Número de Citas"
                };

                barDataset.FillColors.Add(Color.FromArgb(94, 148, 255));
                barDataset.BorderColors.Add(Color.FromArgb(94, 148, 255));
                barDataset.BorderWidth = 2;

                foreach (var item in lista)
                {
                    barDataset.DataPoints.Add(new Guna.Charts.WinForms.LPoint
                    {
                        Label = item.fecha,
                        Y = item.cantidad
                    });
                }

                gunaChart1.YAxes.Display = true;
                gunaChart1.YAxes.GridLines.Display = true;
                gunaChart1.YAxes.Ticks.BeginAtZero = true;

                gunaChart1.XAxes.Display = true;
                gunaChart1.XAxes.GridLines.Display = false;

                gunaChart1.Legend.Display = true;
                gunaChart1.Legend.Position = Guna.Charts.WinForms.LegendPosition.Top;

                gunaChart1.Datasets.Add(barDataset);
                gunaChart1.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el gráfico:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarLabels()
        {
            cardCitasAtendidas.Text = citaService.totalCitas().ToString();
            lblContadorCitasHoy.Text = citaService.totalCitasHoy(DateTime.Now.Date.ToString("dd/MM/yyyy")).ToString();
            lblContadorVeterinarios.Text = veterinarioService.totalVeterinarios().ToString();
            lblContadorMascotas.Text = mascotaService.totalMascotas().ToString();
            lblCitasAtendidas.Text = consultaService.totalConsultasAsistdas(DateTime.Now.Date.ToString("dd/MM/yyyy")).ToString();
        }

        private void FrmEstadistica_Load_1(object sender, EventArgs e)
        {
            cargarDiagrama(citaService.ObtenerCitasPorFechas());
            cargarLabels();
            CargarCitasDelDia(DateTime.Now);
        }

        private void labelCitasAtendidasTitle_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void dgvCitasHoy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int codigo = int.Parse(dgvCitasHoy.CurrentRow.Cells["Codigo"].Value.ToString());
            if (dgvCitasHoy.Columns[e.ColumnIndex].Name == "AtenderCita")
            {
                Cita cita = buscar(codigo);
                if (cita.Fecha.Equals(DateTime.Now.ToString("dd/MM/yyyy")))
                {
                    var frm = new FrmConsultaAgregar(cita.Mascota, cita.Veterinario);
                    mostrarFrm(frm);

                    if (frm.resultado == DialogResult.OK)
                    {
                        eliminar(codigo);
                        CargarCitasDelDia(DateTime.Now);
                    }
                }
                else
                    MessageBox.Show("La fecha de la cita no esta para hoy.", "Atender cita.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool eliminar(int codigo)
        {
            try
            {
                return citaService.Borrar(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar cita: {ex.Message}", ex);
            }
        }

        private void mostrarFrm(Form frm)
        {
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private Cita buscar(int codigo)
        {
            return citaService.buscar(codigo);
        }
    }
}
