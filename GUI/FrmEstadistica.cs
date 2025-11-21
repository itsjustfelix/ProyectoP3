
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
        // Tus servicios (ya los tenías)
        CitaService citaService = new CitaService();
        VeterinarioService veterinarioService = new VeterinarioService();
        MascotaService mascotaService = new MascotaService();
        ConsultaService consultaService = new ConsultaService();

        public FrmEstadistica()
        {
            InitializeComponent();
            // Conectar evento del calendario
            this.monthCalendar1.DateSelected += MonthCalendar1_DateSelected;
        }

        private void FrmEstadistica_Load(object sender, EventArgs e)
        {
            RefrescarTodo();
        }

        private void RefrescarTodo()
        {
            try
            {
                // Cargar gráfico
                var lista = citaService.ObtenerCitasPorFechas();
                if (lista != null)
                    cargarDiagrama(lista);

                // Labels
                cargarLabels();

                // Citas del dia actual
                CargarCitasDelDia(DateTime.Now.Date);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al inicializar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MonthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            CargarCitasDelDia(e.Start);
        }

        private void CargarCitasDelDia(DateTime fecha)
        {
            listBoxCitasDia.Items.Clear();
            listBoxAgenda.Items.Clear();

            // Intenta obtener citas del servicio (ajusta nombres según tu implementación)
            try
            {
                var citas = citaService.buscarPorFecha(fecha.ToString("dd/MM/yyyy")); // adapta si tu método tiene otro nombre
                if (citas != null && citas.Count > 0)
                {
                    foreach (var c in citas)
                    {
                        // Ajusta las propiedades según tu entidad
                        string hora = c.Hora;
                        string mascota = c.Mascota.Nombre;
                        string vet = c.Veterinario.Nombres;
                        string esp = c.Veterinario.Especializacion.Nombre;
                        listBoxCitasDia.Items.Add($"{hora} - {mascota} - Dr. {vet}- {esp}");
                    }
                }
                else
                {
                    listBoxCitasDia.Items.Add("No hay citas para esta fecha.");
                }
            }
            catch
            {
                listBoxCitasDia.Items.Add("No se pudieron cargar las citas (método no disponible).");
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
                MessageBox.Show($"Error al cargar el gráfico:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarLabels()
        {
            try
            {
                // Asegúrate que tus servicios implementan estos métodos
                cardCitasAtendidas.Text = citaService.totalCitas().ToString();
                lblCitasHoy.Text = citaService.totalCitasHoy(DateTime.Now.Date.ToString("dd/MM/yyyy")).ToString();
                lblVeterinarios.Text = veterinarioService.totalVeterinarios().ToString();
                lblMascotas.Text = mascotaService.totalMascotas().ToString();
                lblCitasAtendidas.Text = consultaService.totalConsultasAsistdas(DateTime.Now.Date.ToString("dd/MM/yyyy")).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar contadores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
