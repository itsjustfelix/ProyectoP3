using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entidad;
using Logica;
using Microsoft.VisualBasic;

namespace ProyectoP3
{
    public partial class FrmPropietario : Form
    {
        public FrmPropietario()
        {
            InitializeComponent();
            propietarioService = new PropietarioService();
        }

        PropietarioService propietarioService;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mostrarFrm(new FrmPropietarioAgregar());
            cargarDGV(propietarioService.Consultar());
        }
        
        private void FrmPropietario_Load(object sender, EventArgs e)
        {
            cargarDGV(propietarioService.Consultar());
        }
        
        private void mostrarFrm(Form frm)
        {
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }
        private bool eliminar(int id)
        {
            try
            {
                return propietarioService.Borrar(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        private Propietario buscar(int id)
        {
            try
            {
                return propietarioService.buscar(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
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
        private void cargarDGV(List<Propietario> lista)
        {
            DGVPropietario.Rows.Clear();
            foreach (var item in lista)
            {
                DGVPropietario.Rows.Add(
                    item.Cedula,
                    item.Nombres,
                    item.ApellidoPaterno,
                    item.ApellidoMaterno,
                    item.Sexo,
                    item.Telefono,
                    item.Email
                );
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if(txtFiltrarPropietario.Text.Trim() == "")
            {
                cargarDGV(propietarioService.Consultar());
            }
            else
            {
                cargarDGV(propietarioService.BuscarPorCedula(int.Parse(txtFiltrarPropietario.Text.Trim())));
            }
        }

        private void DGVPropietario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int cedula = int.Parse(DGVPropietario.CurrentRow.Cells["Cedula"].Value.ToString());
            if (DGVPropietario.Columns[e.ColumnIndex].Name == "Editar")
            {
                Propietario propietario = buscar(cedula);
                mostrarFrm(new FrmEditarPropietatio(propietario));
                cargarDGV(propietarioService.Consultar());
            }
            else if (DGVPropietario.Columns[e.ColumnIndex].Name == "elimina")
            {
                var respuesta = dialogoPregunta("eliminar");

                if (respuesta == DialogResult.Yes)
                {
                    eliminar(cedula);
                    MessageBox.Show("Propietario eliminado correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDGV(propietarioService.Consultar());
                }
                else return;
            }
        }
    }
}
