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
        }

        private void FrmEstadistica_Load(object sender, EventArgs e)
        {
            cargarDiagrama(citaService.ObtenerCitasPorFechas());
            cargarLabels();
        }

        private void cargarDiagrama(List<citasPorFechas> lista)
        {
            try
            {
                gunaChart1.Datasets.Clear();
                var barDataset = new Guna.Charts.WinForms.GunaBarDataset();
                barDataset.Label = "Número de Citas";

                barDataset.FillColors.Add(Color.FromArgb(94, 148, 255));
                barDataset.BorderColors.Add(Color.FromArgb(94, 148, 255));
                barDataset.BorderWidth = 2;

                foreach (var item in lista)
                {
                    barDataset.DataPoints.Add(new Guna.Charts.WinForms.LPoint
                    {
                        Label = Convert.ToDateTime(item.fecha).ToString("dd/MM/yyyy"),
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
                MessageBox.Show(
                     $"Error al cargar el gráfico:\n{ex.Message}",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error
                              );
            }
        }

        private void cargarLabels()
        {
            lblTotalCitas.Text = citaService.totalCitas().ToString();
            lblCitasHoy.Text = citaService.totalCitasHoy(DateTime.Now.Date.ToString("dd/MM/yyyy")).ToString();
            lblVeterinarios.Text = veterinarioService.totalVeterinarios().ToString();
            lblMascotas.Text = mascotaService.totalMascotas().ToString();
            lblCitasAtendidas.Text = consultaService.totalConsultasAsistdas(DateTime.Now.Date.ToString("dd/MM/yyyy")).ToString();
        }
    }
}
