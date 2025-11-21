
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
        CitaService citaService = new CitaService();
        VeterinarioService veterinarioService = new VeterinarioService();
        MascotaService mascotaService = new MascotaService();
        ConsultaService consultaService = new ConsultaService();

        public FrmEstadistica()
        {
            InitializeComponent();
            this.monthCalendar1.DateSelected += MonthCalendar1_DateSelected;
        }

        private void MonthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            CargarCitasDelDia(e.Start);
        }

        private void CargarCitasDelDia(DateTime fecha)
        {
            listBoxCitasDia.Items.Clear();
            var citas = citaService.buscarPorFecha(fecha.ToString("dd/MM/yyyy"));
            if (citas != null && citas.Count > 0)
            {
                foreach (var c in citas)
                {
                    listBoxCitasDia.Items.Add($"Hora: {c.Hora}");
                    listBoxCitasDia.Items.Add($"Mascota: {c.Mascota.Nombre}");
                    listBoxCitasDia.Items.Add($"Veterinario: {c.Veterinario.Nombres}");
                    listBoxCitasDia.Items.Add($"Especialiazcion:{c.Veterinario.Especializacion.Nombre}");
                    listBoxCitasDia.Items.Add("--------------------------------------------------");
                }
            }
            else
            {
                listBoxCitasDia.Items.Add("No hay citas para esta fecha.");
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
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
