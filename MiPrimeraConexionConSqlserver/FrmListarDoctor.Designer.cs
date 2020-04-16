namespace MiPrimeraConexionConSqlserver
{
    partial class FrmListarDoctor
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
            this.DgvDoctor = new System.Windows.Forms.DataGridView();
            this.RbPaterno = new System.Windows.Forms.RadioButton();
            this.RbApellidoMaterno = new System.Windows.Forms.RadioButton();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDoctor)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvDoctor
            // 
            this.DgvDoctor.AllowUserToAddRows = false;
            this.DgvDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDoctor.Location = new System.Drawing.Point(12, 97);
            this.DgvDoctor.Name = "DgvDoctor";
            this.DgvDoctor.ReadOnly = true;
            this.DgvDoctor.RowTemplate.Height = 24;
            this.DgvDoctor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDoctor.Size = new System.Drawing.Size(763, 323);
            this.DgvDoctor.TabIndex = 0;
            // 
            // RbPaterno
            // 
            this.RbPaterno.AutoSize = true;
            this.RbPaterno.Location = new System.Drawing.Point(13, 63);
            this.RbPaterno.Name = "RbPaterno";
            this.RbPaterno.Size = new System.Drawing.Size(133, 21);
            this.RbPaterno.TabIndex = 1;
            this.RbPaterno.TabStop = true;
            this.RbPaterno.Text = "Apellido Paterno";
            this.RbPaterno.UseVisualStyleBackColor = true;
            // 
            // RbApellidoMaterno
            // 
            this.RbApellidoMaterno.AutoSize = true;
            this.RbApellidoMaterno.Location = new System.Drawing.Point(164, 63);
            this.RbApellidoMaterno.Name = "RbApellidoMaterno";
            this.RbApellidoMaterno.Size = new System.Drawing.Size(135, 21);
            this.RbApellidoMaterno.TabIndex = 2;
            this.RbApellidoMaterno.TabStop = true;
            this.RbApellidoMaterno.Text = "Apellido Materno";
            this.RbApellidoMaterno.UseVisualStyleBackColor = true;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(319, 63);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(217, 22);
            this.TxtApellido.TabIndex = 3;
            this.TxtApellido.TextChanged += new System.EventHandler(this.Listar);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.BtnNuevo);
            this.flowLayoutPanel1.Controls.Add(this.BtnEliminar);
            this.flowLayoutPanel1.Controls.Add(this.BtnEditar);
            this.flowLayoutPanel1.Controls.Add(this.BtnImprimir);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(775, 44);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(3, 3);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(114, 32);
            this.BtnNuevo.TabIndex = 0;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(123, 3);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(114, 32);
            this.BtnEliminar.TabIndex = 1;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(243, 3);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(114, 32);
            this.BtnEditar.TabIndex = 2;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Location = new System.Drawing.Point(363, 3);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(114, 32);
            this.BtnImprimir.TabIndex = 3;
            this.BtnImprimir.Text = "Imprimir";
            this.BtnImprimir.UseVisualStyleBackColor = true;
            // 
            // FrmListarDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.RbApellidoMaterno);
            this.Controls.Add(this.RbPaterno);
            this.Controls.Add(this.DgvDoctor);
            this.Name = "FrmListarDoctor";
            this.Text = "Listado de Doctores";
            this.Load += new System.EventHandler(this.FrmListarDoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDoctor)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvDoctor;
        private System.Windows.Forms.RadioButton RbPaterno;
        private System.Windows.Forms.RadioButton RbApellidoMaterno;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnImprimir;
    }
}