using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entidad;
using Logica;
using Microsoft.VisualBasic;
namespace ProyectoP3
{
    public partial class FrmEspecializacion : Form
    {
        EspecializacionService logEspecializacion;
        public FrmEspecializacion()
        {
            InitializeComponent();
            logEspecializacion = new EspecializacionService();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mostrarFrm(new FrmEspecializacionAgregar());
            cargarDGV(logEspecializacion.Consultar());
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(Interaction.InputBox("Digite el codigo de la especializacion ha eliminar", "Eliminar especilizacion", ""));
                Especializacion especializacion = buscar(id);
                if (especializacion == null)
                {
                    MessageBox.Show("Propietario no encontrado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                var respuesta = dialogoPregunta("eliminar");
                if (respuesta == DialogResult.Yes)
                {
                    eliminar(id);
                    MessageBox.Show("Eliminación cancelada", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDGV(logEspecializacion.Consultar());
                    return;
                }
                else
                {
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bttnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(Interaction.InputBox("Digite el codigo de la especializacion ha buscar", "Buscar especializacion", ""));
                Especializacion especializacion = buscar(id);
                if (especializacion == null)
                {
                    MessageBox.Show("Especializacion no encontrada", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                mostrarFrm(new FrmEspecializacionEditar(especializacion));
                cargarDGV(logEspecializacion.Consultar());
            }
            catch (Exception)
            {
                MessageBox.Show("el codigo debe ser solamente numeros", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cargarDGV(List<Especializacion> lista)
        {
            DGVEspecializacion.Rows.Clear();
            foreach (var item in lista)
            {
                DGVEspecializacion.Rows.Add(item.Codigo, item.Nombre);
            }
        }

        private void mostrarFrm(Form frm)
        {
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
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

        private void FrmEspecializacion_Load(object sender, EventArgs e)
        {
            cargarDGV(logEspecializacion.Consultar());
        }

        

        private bool eliminar(int id)
        {
            try
            {
                return logEspecializacion.Borrar(id);
            }
            catch (Exception e)
            {
                throw new Exception($"Error al agregar la consulta: {e.Message}", e);
            }
        }

        private Especializacion buscar(int id)
        {
            try
            {
                return logEspecializacion.BuscarPorId(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }

        private void bttnFiltrarPorNombre_Click(object sender, EventArgs e)
        {
            if (txtFiltrarPorNombre.Text.Trim() == "")
            {
                cargarDGV(logEspecializacion.Consultar());
                return;
            }
            else
            {
                cargarDGV(logEspecializacion.BuscarPorNombre(txtFiltrarPorNombre.Text.Trim()));
            }
        }
    }
}
