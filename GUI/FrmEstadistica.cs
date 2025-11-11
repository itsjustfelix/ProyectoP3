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
        public FrmEstadistica()
        {
            InitializeComponent();
        }

        private void FrmEstadistica_Load(object sender, EventArgs e)
        {
            cargarDiagrama();
            cargarLabelCitasTotal();
        }

        private void cargarDiagrama()
        {
            try
            {
                // 1. Obtener datos de la base de datos
                List<citasPorFechas> datos = citaService.ObtenerCitasPorFechas();

                // 4. Limpiar datos anteriores del gráfico
                gunaChart1.Datasets.Clear();

                // 5. Crear el dataset de barras
                var barDataset = new Guna.Charts.WinForms.GunaBarDataset();
                barDataset.Label = "Número de Citas";

                // 6. Personalizar colores
                barDataset.FillColors.Add(Color.FromArgb(94, 148, 255));
                barDataset.BorderColors.Add(Color.FromArgb(94, 148, 255));
                barDataset.BorderWidth = 2;

                // 7. Agregar los datos al dataset
                foreach (var item in datos)
                {
                    barDataset.DataPoints.Add(new Guna.Charts.WinForms.LPoint
                    {
                        Label = Convert.ToDateTime(item.fecha).ToString("dd/MM/yyyy"),
                        Y = item.cantidad
                    });
                }

                // 8. Configurar el eje Y
                gunaChart1.YAxes.Display = true;
                gunaChart1.YAxes.GridLines.Display = true;
                gunaChart1.YAxes.Ticks.BeginAtZero = true;

                // 9. Configurar el eje X
                gunaChart1.XAxes.Display = true;
                gunaChart1.XAxes.GridLines.Display = false;

                // 10. Configurar la leyenda
                gunaChart1.Legend.Display = true;
                gunaChart1.Legend.Position = Guna.Charts.WinForms.LegendPosition.Top;

                // 11. Agregar el dataset al gráfico
                gunaChart1.Datasets.Add(barDataset);

                // 12. Actualizar la visualización
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

        private void cargarLabelCitasTotal()
        {
            int totalCitas = citaService.Consultar().Count;
            lblTotalCitas.Text = totalCitas.ToString();
        }
    }
}
