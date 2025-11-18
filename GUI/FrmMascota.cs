using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entidad;
using Logica;
using Microsoft.VisualBasic;

namespace ProyectoP3
{
    public partial class FrmMascota : Form
    {
        MascotaService mascotaService;
        public FrmMascota()
        {
            InitializeComponent();
            mascotaService = new MascotaService();
        }
        private void cargarDGV(List<Mascota> lista)
        {
            DGVMascota.Rows.Clear();
            foreach (var item in lista)
            {
                DGVMascota.Rows.Add(
                    item.Codigo,
                    item.Nombre,
                    item.Especie.Nombre,
                    item.Raza.Nombre,
                    item.Propietario.Nombres
                    );
            }
        }
        
        private Mascota buscar(int id)
        {
            return mascotaService.buscar(id);
        }
        private bool borrar(int id)
        {
            try
            {
                return mascotaService.Borrar(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
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
        private Mascota buscarMascota(int id)
        {
            return mascotaService.buscar(id);
        }
        private void mostrarFrm(Form frm)
        {
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }
        private void FrmMascota_Load(object sender, EventArgs e)
        {
            cargarDGV(mascotaService.Consultar());
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mostrarFrm(new FrmMascotaAgregar());
            cargarDGV(mascotaService.Consultar());
        }

        private void bttnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string input = Interaction.InputBox(
                    "Digite el codigo de la mascota a buscar",
                    "Buscar Mascota",
                    ""
                );

                if (string.IsNullOrWhiteSpace(input)) return;
                 
                if (!int.TryParse(input, out int id))
                {
                    MessageBox.Show("Debe digitar un número válido.");
                    return;
                }

                Mascota mascota = buscarMascota(id);
                if (mascota == null)
                {
                    MessageBox.Show("Mascota no encontrada", "Buscar Mascota",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                mostrarFrm(new FrmMascotaEditar(mascota));
                cargarDGV(mascotaService.Consultar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string input = Interaction.InputBox(
                    "Digite el codigo de la mascota a eliminar",
                    "Eliminar Mascota",
                    ""
                );
                if (string.IsNullOrWhiteSpace(input)) return;
                
                if (!int.TryParse(input, out int id))
                {
                    MessageBox.Show("Debe digitar un número válido.");
                    return;
                }

                Mascota mascota = buscar(id);
                if (mascota == null)
                {
                    MessageBox.Show("Mascota no encontrada", "Eliminar Mascota",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult result = dialogoPregunta("eliminar la mascota");
                if (result == DialogResult.No)return;
                if (borrar(id))
                {
                    MessageBox.Show("Mascota eliminada correctamente.", "Eliminar Mascota",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDGV(mascotaService.Consultar());
                }
                else
                    MessageBox.Show("No se pudo  eliminada la Mascota correctamente.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void bttnFiltrarPorRaza_Click(object sender, EventArgs e)
        {
            if(txtFiltrarRaza.Text.Trim() == "")
            {
                cargarDGV(mascotaService.Consultar());
                return;
            }
            else
            {
                cargarDGV(mascotaService.BuscarPorRaza(txtFiltrarRaza.Text.Trim()));
            }
        }

        private void bttnFiltrarPorEspecie_Click(object sender, EventArgs e)
        {
            if (txtFiltrarEspecie.Text.Trim() == "")
            {
                cargarDGV(mascotaService.Consultar());
                return;
            }
            else
            {
                cargarDGV(mascotaService.BuscarPorEspecie(txtFiltrarEspecie.Text.Trim()));
            }
        }

        private void bttnFiltrarPorPropietario_Click(object sender, EventArgs e)
        {
            if (txtFiltrarPropietario.Text.Trim() == "")
            {
                cargarDGV(mascotaService.Consultar());
                return;
            }
            else
            {
                cargarDGV(mascotaService.BuscarPorPropietario(int.Parse(txtFiltrarPropietario.Text.Trim())));
            }
        }

        private void DGVMascota_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int codigo = int.Parse(DGVMascota.CurrentRow.Cells["Codigo"].Value.ToString());
            if (DGVMascota.Columns[e.ColumnIndex].Name == "Editar")
            {
                Mascota mascota = buscar(codigo);
                mostrarFrm(new FrmMascotaEditar(mascota));
                cargarDGV(mascotaService.Consultar());
            }
            else if (DGVMascota.Columns[e.ColumnIndex].Name == "elimina")
            {
                var respuesta = dialogoPregunta("eliminar");
                if (respuesta == DialogResult.Yes)
                {
                    borrar(codigo);
                    MessageBox.Show("Veterinario eliminado correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDGV(mascotaService.Consultar());
                }
            }
        }
    }
}
