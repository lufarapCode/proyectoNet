
namespace UI.windows.Forms
{
    partial class FrmTarea
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridTarea = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDT = new System.Windows.Forms.TextBox();
            this.txtTarea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateFecVen = new System.Windows.Forms.DateTimePicker();
            this.boxPrioridad = new System.Windows.Forms.ComboBox();
            this.boxEstado = new System.Windows.Forms.ComboBox();
            this.boxIDP = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtIDP = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTarea)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIDP);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.boxIDP);
            this.groupBox1.Controls.Add(this.boxEstado);
            this.groupBox1.Controls.Add(this.boxPrioridad);
            this.groupBox1.Controls.Add(this.dateFecVen);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.txtTarea);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIDT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // gridTarea
            // 
            this.gridTarea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTarea.Location = new System.Drawing.Point(30, 276);
            this.gridTarea.Name = "gridTarea";
            this.gridTarea.Size = new System.Drawing.Size(612, 191);
            this.gridTarea.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Tarea";
            // 
            // txtIDT
            // 
            this.txtIDT.Enabled = false;
            this.txtIDT.Location = new System.Drawing.Point(88, 25);
            this.txtIDT.Name = "txtIDT";
            this.txtIDT.Size = new System.Drawing.Size(117, 20);
            this.txtIDT.TabIndex = 1;
            // 
            // txtTarea
            // 
            this.txtTarea.Location = new System.Drawing.Point(88, 54);
            this.txtTarea.Name = "txtTarea";
            this.txtTarea.Size = new System.Drawing.Size(204, 20);
            this.txtTarea.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tarea";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(88, 88);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(204, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(19, 91);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(63, 13);
            this.label.TabIndex = 4;
            this.label.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha Vencimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Prioridad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Estado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(319, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "ID Proyecto";
            // 
            // dateFecVen
            // 
            this.dateFecVen.Location = new System.Drawing.Point(123, 118);
            this.dateFecVen.Name = "dateFecVen";
            this.dateFecVen.Size = new System.Drawing.Size(200, 20);
            this.dateFecVen.TabIndex = 14;
            // 
            // boxPrioridad
            // 
            this.boxPrioridad.FormattingEnabled = true;
            this.boxPrioridad.Items.AddRange(new object[] {
            "Alta ",
            "Normal",
            "Baja"});
            this.boxPrioridad.Location = new System.Drawing.Point(88, 159);
            this.boxPrioridad.Name = "boxPrioridad";
            this.boxPrioridad.Size = new System.Drawing.Size(204, 21);
            this.boxPrioridad.TabIndex = 15;
            // 
            // boxEstado
            // 
            this.boxEstado.FormattingEnabled = true;
            this.boxEstado.Items.AddRange(new object[] {
            "Activo",
            "Desactivo"});
            this.boxEstado.Location = new System.Drawing.Point(387, 19);
            this.boxEstado.Name = "boxEstado";
            this.boxEstado.Size = new System.Drawing.Size(204, 21);
            this.boxEstado.TabIndex = 16;
            // 
            // boxIDP
            // 
            this.boxIDP.FormattingEnabled = true;
            this.boxIDP.Location = new System.Drawing.Point(387, 53);
            this.boxIDP.Name = "boxIDP";
            this.boxIDP.Size = new System.Drawing.Size(204, 21);
            this.boxIDP.TabIndex = 17;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(499, 159);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(30, 245);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // txtIDP
            // 
            this.txtIDP.Location = new System.Drawing.Point(387, 84);
            this.txtIDP.Name = "txtIDP";
            this.txtIDP.Size = new System.Drawing.Size(204, 20);
            this.txtIDP.TabIndex = 19;
            // 
            // FrmTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 479);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gridTarea);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmTarea";
            this.Text = "FrmTarea";
            this.Load += new System.EventHandler(this.FrmTarea_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTarea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIDP;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox boxIDP;
        private System.Windows.Forms.ComboBox boxEstado;
        private System.Windows.Forms.ComboBox boxPrioridad;
        private System.Windows.Forms.DateTimePicker dateFecVen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtTarea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridTarea;
        private System.Windows.Forms.Button btnNuevo;
    }
}