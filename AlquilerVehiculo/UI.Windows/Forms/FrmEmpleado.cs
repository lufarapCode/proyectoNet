using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Windows.AplicationController;
using UI.Windows.ViewModel;

namespace UI.Windows
{
    public partial class FrmEmpleado : Form
    {

        private EmpleadoController controllerEmpleado;
        private EmpleadoViewModel viewModelEmpleado;

        public FrmEmpleado()
        {
            InitializeComponent();
            controllerEmpleado = new EmpleadoController();
        }

        public void InsertarEmpleado()
        {
            if (controllerEmpleado.InsertarEmpleado(viewModelEmpleado))
            {
                MessageBox.Show("Empleado insertado correctamente");
            }
            else
            {
                MessageBox.Show("Error al insertar Empleado");
            }
        }

        public void ActualizarEmpleado()
        {
            if (controllerEmpleado.ActualizarEmpleado(viewModelEmpleado))
            {
                MessageBox.Show("Empleado actualizado correctamente");
            }
            else
            {
                MessageBox.Show("Error al actualizar Empleado");
            }
        }

        private void ListarEmpleadosActivos()
        {
            dgvListaEmpleados.DataSource = controllerEmpleado.ListarEmpleadoActivo();
        }


        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            viewModelEmpleado = new EmpleadoViewModel();
            viewModelEmpleado.Nombre = txtNombre.Text;
            viewModelEmpleado.Apellido = txtApellido.Text;
            viewModelEmpleado.Direccion = txtDireccion.Text;
            viewModelEmpleado.Telefono = txtTelefono.Text;

            if (chkActivo.Checked)
            {
                viewModelEmpleado.Estado = 1;
            }
            else
            {
                viewModelEmpleado.Estado = 0;
            }

            if (txtId.Text != "")
            {
                viewModelEmpleado.Id_empleado = int.Parse(txtId.Text);
                ActualizarEmpleado();

            }
            else
            {
                InsertarEmpleado();
            }

            ListarEmpleadosActivos();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            grBox.Enabled = true;
        }

        // load metodo inicializador
        private void Form1_Load(object sender, EventArgs e)
        {
            ListarEmpleadosActivos();
        }
    }
}
