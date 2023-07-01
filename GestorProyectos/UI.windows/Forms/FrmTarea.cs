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

namespace UI.windows.Forms
{
    public partial class FrmTarea : Form
    {

        private TareaController controllerTarea;
        private TareaVistaModelo viewModelTarea;

        public FrmTarea()
        {
            InitializeComponent();
            controllerTarea = new TareaController();
        }

        public void InsertarTarea()
        {
            if (controllerTarea.InsertarTarea(viewModelTarea))
            {
                MessageBox.Show("Tarea insertada correctamente");
            }
            else
            {
                MessageBox.Show("Error al insertar Tarea");
            }
        }

        public void ActualizarTarea()
        {
            if (controllerTarea.ActualizarTarea(viewModelTarea))
            {
                MessageBox.Show("Tarea actualizada correctamente");
            }
            else
            {
                MessageBox.Show("Error al actualizar Tarea");
            }
        }

        private void ListarTareas()
        {
            gridTarea.DataSource = controllerTarea.GetTarea();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            viewModelTarea = new TareaVistaModelo();
            viewModelTarea.TituloTarea = txtTarea.Text;
            viewModelTarea.DescripcionTarea = txtDescripcion.Text;
            viewModelTarea.FechaVencimientoTarea = dateFecVen.Value;
            viewModelTarea.PrioridadTarea = boxPrioridad.Text;
            viewModelTarea.EstadoTarea = boxEstado.Text;
            viewModelTarea.IdProyecto = int.Parse(txtIDP.Text);
            //viewModelTarea.IdProyecto = int.Parse(boxIDP.Text);

            if (txtIDT.Text != "")
            {
                viewModelTarea.IdTarea = int.Parse(txtIDT.Text);
                ActualizarTarea();

            }
            else
            {
                InsertarTarea();
            }

            ListarTareas();
        }

        private void FrmTarea_Load(object sender, EventArgs e)
        {
            ListarTareas();
        }
    }
}
