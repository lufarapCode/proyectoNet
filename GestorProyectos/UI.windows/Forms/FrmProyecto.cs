using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.windows.AplicationController;
using UI.windows.ViewModel;

namespace UI.windows
{
    public partial class FrmProyecto : Form
    {
        private ProyectosController controllerProyecto;
        private ProyectoVistaModelo viewModelProyecto;

        public FrmProyecto()
        {
            InitializeComponent();
            controllerProyecto = new ProyectosController();
        }

        public void InsertarProyecto()
        {
            if (controllerProyecto.InsertarProyecto(viewModelProyecto))
            {
                MessageBox.Show("Proyecto insertado correctamente");
            }
            else
            {
                MessageBox.Show("Error al insertar Proyecto");
            }
        }

        public void ActualizarProyecto()
        {
            if (controllerProyecto.ActualizarProyecto(viewModelProyecto))
            {
                MessageBox.Show("Proyecto actualizado correctamente");
            }
            else
            {
                MessageBox.Show("Error al actualizar Proyecto");
            }
        }

        private void ListarProyectos()
        {
            gridProyecto.DataSource = controllerProyecto.GetProyecto();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            viewModelProyecto = new ProyectoVistaModelo();
            viewModelProyecto.NombreProyecto = txtNuevoP.Text;
            viewModelProyecto.DescripcionProyecto = txtDescP.Text;
            viewModelProyecto.FechaInicioProyecto = dateFIP.Value;
            viewModelProyecto.FechaFinProyecto = dateFFP.Value;
            viewModelProyecto.EstadoProyecto = cmbEstado.Text;

            if (txtIdPro.Text != "")
            {
                viewModelProyecto.IdProyecto = int.Parse(txtIdPro.Text);
                ActualizarProyecto();

            }
            else
            {
                InsertarProyecto();
            }

            ListarProyectos();

        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmProyecto_Load(object sender, EventArgs e)
        {
            ListarProyectos();
        }
    }
}
