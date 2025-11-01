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
using Microsoft.VisualBasic;

namespace ProyectoP3
{
    public partial class FrmMascota : Form
    {
        public FrmMascota()
        {
            InitializeComponent();
        }
        ICrud<Mascota> logMascota = new LogMascota();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            mostrarFrm(new FrmMascotaAgregar());
            cargarDGV();
        }
        private void cargarDGV()
        {
            DGVMascota.Rows.Clear();
            foreach (var item in logMascota.Consultar())
            {
                DGVMascota.Rows.Add(item.Codigo, item.Nombre, item.Especie.Nombre, item.Raza.Nombre, item.Propietario.Nombres);
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = Interaction.InputBox("Digite el codigo de la mascota a buscar", "Buscar Mascota", "");
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
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = Interaction.InputBox("Digite el codigo de la mascota ha eliminar", "Eliminar mascota", "");
                Mascota mascota = buscar(id);
                if (mascota == null)
                {
                    MessageBox.Show("Mascota no encontrada", "Eliminar Mascota", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DialogResult result = dialogoPregunta("eliminar la mascota");
                if (result == DialogResult.No || result == DialogResult.None)
                {
                    MessageBox.Show("Operación cancelada.", "Eliminar Mascota", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string message = borrar(id);
                MessageBox.Show(message, "Eliminar Mascota", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private Mascota buscar(string id)
        {
            return logMascota.BuscarPorId(id);
        }
        private string borrar(string id)
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
        private Mascota buscarMascota(string id)
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
    }
}
