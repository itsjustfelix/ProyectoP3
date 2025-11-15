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
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string input = Interaction.InputBox("Digite la cedula del propietario ha buscar", "Buscar Propietario", "");

                if (string.IsNullOrWhiteSpace(input))
                    return;

                if (!int.TryParse(input, out int id))
                    throw new Exception("La cedula debe ser solamente numeros");

                Propietario propietario = buscar(id);

                if (propietario == null)
                {
                    MessageBox.Show("Propietario no encontrado", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                mostrarFrm(new FrmEditarPropietatio(propietario));
                cargarDGV(propietarioService.Consultar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmPropietario_Load(object sender, EventArgs e)
        {
            cargarDGV(propietarioService.Consultar());
        }
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string input = Interaction.InputBox("Digite el ID de la persona ha eliminar", "Eliminar Propietario", "");

                if (string.IsNullOrWhiteSpace(input))
                    return;

                if (!int.TryParse(input, out int id))
                    throw new Exception("El ID debe ser solamente numeros");

                Propietario propietario = buscar(id);

                if (propietario == null)
                {
                    MessageBox.Show("Propietario no encontrado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var respuesta = dialogoPregunta("eliminar");

                if (respuesta == DialogResult.Yes)
                {
                    eliminar(id);
                    MessageBox.Show("Propietario eliminado correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDGV(propietarioService.Consultar());
                }
                else return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                return propietarioService.BuscarPorId(id);
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
    }
}
