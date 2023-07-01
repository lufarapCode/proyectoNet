namespace UI.windows
{
    partial class formProyecto
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNuevoP = new System.Windows.Forms.TextBox();
            this.gridProyecto = new System.Windows.Forms.DataGridView();
            this.txtDescP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dateFIP = new System.Windows.Forms.DateTimePicker();
            this.dateFFP = new System.Windows.Forms.DateTimePicker();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdPro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridProyecto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Proyecto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNuevoP
            // 
            this.txtNuevoP.Location = new System.Drawing.Point(180, 44);
            this.txtNuevoP.Name = "txtNuevoP";
            this.txtNuevoP.Size = new System.Drawing.Size(241, 20);
            this.txtNuevoP.TabIndex = 1;
            // 
            // gridProyecto
            // 
            this.gridProyecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProyecto.Location = new System.Drawing.Point(42, 283);
            this.gridProyecto.Name = "gridProyecto";
            this.gridProyecto.Size = new System.Drawing.Size(679, 186);
            this.gridProyecto.TabIndex = 2;
            // 
            // txtDescP
            // 
            this.txtDescP.Location = new System.Drawing.Point(180, 77);
            this.txtDescP.Name = "txtDescP";
            this.txtDescP.Size = new System.Drawing.Size(241, 20);
            this.txtDescP.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripcion del proyecto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha Inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha Fin";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(565, 47);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(180, 239);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 13;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // dateFIP
            // 
            this.dateFIP.Location = new System.Drawing.Point(180, 117);
            this.dateFIP.Name = "dateFIP";
            this.dateFIP.Size = new System.Drawing.Size(241, 20);
            this.dateFIP.TabIndex = 14;
            // 
            // dateFFP
            // 
            this.dateFFP.Location = new System.Drawing.Point(180, 154);
            this.dateFFP.Name = "dateFFP";
            this.dateFFP.Size = new System.Drawing.Size(241, 20);
            this.dateFFP.TabIndex = 15;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Activo",
            "Desactivado"});
            this.cmbEstado.Location = new System.Drawing.Point(180, 191);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(241, 21);
            this.cmbEstado.TabIndex = 16;
            this.cmbEstado.Text = "Activo";
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Estado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "ID Proyecto";
            // 
            // txtIdPro
            // 
            this.txtIdPro.Enabled = false;
            this.txtIdPro.Location = new System.Drawing.Point(180, 15);
            this.txtIdPro.Name = "txtIdPro";
            this.txtIdPro.Size = new System.Drawing.Size(241, 20);
            this.txtIdPro.TabIndex = 19;
            // 
            // formProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.txtIdPro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.dateFFP);
            this.Controls.Add(this.dateFIP);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridProyecto);
            this.Controls.Add(this.txtNuevoP);
            this.Controls.Add(this.label1);
            this.Name = "formProyecto";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.formProyecto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProyecto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNuevoP;
        private System.Windows.Forms.DataGridView gridProyecto;
        private System.Windows.Forms.TextBox txtDescP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DateTimePicker dateFIP;
        private System.Windows.Forms.DateTimePicker dateFFP;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdPro;
    }
}

