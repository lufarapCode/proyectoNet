using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.windows.Forms
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void proyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ventana = "FrmProyecto";
            if(VentanaAbierta(ventana) == false){
                FrmProyecto frmP = new FrmProyecto();
                frmP.MdiParent = this;
                frmP.Show();
            }
            
        }

        private void tareasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ventana = "FrmTarea";
            if (VentanaAbierta(ventana) == false)
            {
                FrmTarea frmT = new FrmTarea();
                frmT.MdiParent = this;
                frmT.Show();
            }
               
        }

        private bool VentanaAbierta(string nombreVen)
        {
            bool va = false;
            foreach(Form ven in MdiChildren){

                if (ven.Name.Equals(nombreVen))
                {
                    ven.Focus();
                    va = true;
                }
            }
            return va;
        }
    }
}
