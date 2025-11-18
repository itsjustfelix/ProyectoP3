using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entidad;
using Logica;
using Microsoft.VisualBasic;

namespace ProyectoP3
{
    public partial class FrmVeterinario : Form
    {
        VeterinarioService VeterinarioService;
        public FrmVeterinario()
        {
            InitializeComponent();
            VeterinarioService = new VeterinarioService();
        }

        private void FrmVeterinario_Load(object sender, EventArgs e)
        {
            cargarDGV(VeterinarioService.Consultar());
        }

        private Veterinario buscar(int codigo)
        {
            try
            {
                return VeterinarioService.buscar(codigo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }
        private bool eliminar(int codigo)
        {
            try
            {
                return VeterinarioService.Borrar(codigo);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
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
        private void cargarDGV(List<Veterinario> lista)
        {
            DGVeterinario.Rows.Clear();
            foreach (var item in lista)
            {
                DGVeterinario.Rows.Add(
                    item.Cedula,
                    item.Nombres,
                    item.ApellidoMaterno,
                    item.ApellidoMaterno,
                    item.Sexo,
                    item.Telefono,
                    item.Especializacion.Nombre);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mostrarFrm(new FrmVeterinarioAgregar());
            cargarDGV(VeterinarioService.Consultar());
        }

        private void bttnFiltrarPorEspecialidad_Click(object sender, EventArgs e)
        {
            if(txtFiltrarEspecializacion.Text.Trim() == "")
            {
                cargarDGV(VeterinarioService.Consultar());
            }
            else
            {
                cargarDGV(VeterinarioService.bsucarPorNombreEspecializacion(txtFiltrarEspecializacion.Text.Trim()));
            }
        }

        private void DGVeterinario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int cedula = int.Parse(DGVeterinario.CurrentRow.Cells["Cedula"].Value.ToString());
            if (DGVeterinario.Columns[e.ColumnIndex].Name == "Editar")
            {
                Veterinario veterinario = buscar(cedula);
                mostrarFrm(new FrmVeterinarioEditar(veterinario));
                cargarDGV(VeterinarioService.Consultar());
            }else if(DGVeterinario.Columns[e.ColumnIndex].Name == "elimina")
            {
                var respuesta = dialogoPregunta("eliminar");
                if (respuesta == DialogResult.Yes)
                {
                    eliminar(cedula);
                    MessageBox.Show("Veterinario eliminado correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDGV(VeterinarioService.Consultar());
                }
            }
        }
    }
}
