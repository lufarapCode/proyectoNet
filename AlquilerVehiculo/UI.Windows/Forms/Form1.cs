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
    public partial class Form1 : Form
    {

        private EmpleadoController controllerEmpleado;
        private EmpleadoViewModel viewModelEmpleado;

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

        public Form1()
        {
            InitializeComponent();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            viewModelEmpleado = new EmpleadoViewModel();
            viewModelEmpleado.Nombre = txtNombre.Text;
            viewModelEmpleado.Apellido = txtApellido.Text;
            viewModelEmpleado.Direccion = txtDireccion.Text;
            viewModelEmpleado.Telefono = txtTelefono.Text;

            if (chkEstado.Checked)
            {
                viewModelEmpleado.Estado = 1;
            }
            else
            {
                viewModelEmpleado.Estado = 0;
            }

            if(txtIdEmpleado.Text != "")
            {
                viewModelEmpleado.Id_empleado = int.Parse(txtIdEmpleado.Text);
                ActualizarEmpleado();

            }
            else
            {
                InsertarEmpleado();
            }


        }

    }
}
