using System;
using System.Windows.Forms;
using Entidad;
using Logica;
using Microsoft.VisualBasic;

namespace ProyectoP3
{
    public partial class FrmMascota : Form
    {
        ICrud<Mascota> logMascota;
        public FrmMascota()
        {
            InitializeComponent();
            logMascota = new MascotaService();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }
        private void cargarDGV()
        {
            DGVMascota.Rows.Clear();
            foreach (var item in logMascota.Consultar())
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
        private void btnEditar_Click(object sender, EventArgs e)
        {
            
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
        }
        private Mascota buscar(int id)
        {
            return logMascota.BuscarPorId(id);
        }
        private bool borrar(int id)
        {
            try
            {
                return logMascota.Borrar(id);
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
            return logMascota.BuscarPorId(id);
        }
        private void mostrarFrm(Form frm)
        {
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }
        private void FrmMascota_Load(object sender, EventArgs e)
        {
            cargarDGV();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mostrarFrm(new FrmMascotaAgregar());
            cargarDGV();
        }

        private void bttnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(Interaction.InputBox("Digite el codigo de la mascota a buscar", "Buscar Mascota", ""));
                Mascota mascota = buscarMascota(id);
                if (mascota == null)
                {
                    MessageBox.Show("Mascota no encontrada", "Buscar Mascota", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                mostrarFrm(new FrmMascotaEditar(mascota));
                cargarDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(Interaction.InputBox("Digite el codigo de la mascota ha eliminar", "Eliminar mascota", ""));
                Mascota mascota = buscar(id);
                if (mascota == null)
                {
                    MessageBox.Show("Mascota no encontrada", "Eliminar Mascota", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DialogResult result = dialogoPregunta("eliminar la mascota");
                if (result == DialogResult.Yes)
                {
                    borrar(id);
                    MessageBox.Show("Mascota eliminada correctamente.", "Eliminar Mascota", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDGV();
                    return;
                }
                else return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
