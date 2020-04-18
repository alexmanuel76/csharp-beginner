namespace MiPrimeraConexionConSqlserver
{
    partial class FrmListadoMedicamentos
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
            this.DgvMedicamentos = new System.Windows.Forms.DataGridView();
            this.RbNombre = new System.Windows.Forms.RadioButton();
            this.RbConcentracion = new System.Windows.Forms.RadioButton();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.FlpBonones = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMedicamentos)).BeginInit();
            this.FlpBonones.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvMedicamentos
            // 
            this.DgvMedicamentos.AllowUserToAddRows = false;
            this.DgvMedicamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DgvMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMedicamentos.Location = new System.Drawing.Point(12, 135);
            this.DgvMedicamentos.Name = "DgvMedicamentos";
            this.DgvMedicamentos.ReadOnly = true;
            this.DgvMedicamentos.RowTemplate.Height = 24;
            this.DgvMedicamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvMedicamentos.Size = new System.Drawing.Size(743, 303);
            this.DgvMedicamentos.TabIndex = 0;
            // 
            // RbNombre
            // 
            this.RbNombre.AutoSize = true;
            this.RbNombre.Location = new System.Drawing.Point(20, 73);
            this.RbNombre.Name = "RbNombre";
            this.RbNombre.Size = new System.Drawing.Size(79, 21);
            this.RbNombre.TabIndex = 1;
            this.RbNombre.TabStop = true;
            this.RbNombre.Text = "Nombre";
            this.RbNombre.UseVisualStyleBackColor = true;
            // 
            // RbConcentracion
            // 
            this.RbConcentracion.AutoSize = true;
            this.RbConcentracion.Location = new System.Drawing.Point(136, 73);
            this.RbConcentracion.Name = "RbConcentracion";
            this.RbConcentracion.Size = new System.Drawing.Size(120, 21);
            this.RbConcentracion.TabIndex = 2;
            this.RbConcentracion.TabStop = true;
            this.RbConcentracion.Text = "Concentracion";
            this.RbConcentracion.UseVisualStyleBackColor = true;
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(313, 73);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(196, 22);
            this.TxtValor.TabIndex = 3;
            this.TxtValor.TextChanged += new System.EventHandler(this.Filtrar);
            // 
            // FlpBonones
            // 
            this.FlpBonones.Controls.Add(this.BtnNuevo);
            this.FlpBonones.Controls.Add(this.BtnEditar);
            this.FlpBonones.Controls.Add(this.BtnEliminar);
            this.FlpBonones.Controls.Add(this.BtnImprimir);
            this.FlpBonones.Location = new System.Drawing.Point(4, 7);
            this.FlpBonones.Name = "FlpBonones";
            this.FlpBonones.Size = new System.Drawing.Size(793, 46);
            this.FlpBonones.TabIndex = 6;
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
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(123, 3);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(114, 32);
            this.BtnEditar.TabIndex = 1;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(243, 3);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(114, 32);
            this.BtnEliminar.TabIndex = 2;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
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
            // FrmListadoMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FlpBonones);
            this.Controls.Add(this.TxtValor);
            this.Controls.Add(this.RbConcentracion);
            this.Controls.Add(this.RbNombre);
            this.Controls.Add(this.DgvMedicamentos);
            this.Name = "FrmListadoMedicamentos";
            this.Text = "Listado de Medicamentos";
            this.Load += new System.EventHandler(this.FrmListadoMedicamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMedicamentos)).EndInit();
            this.FlpBonones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvMedicamentos;
        private System.Windows.Forms.RadioButton RbNombre;
        private System.Windows.Forms.RadioButton RbConcentracion;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.FlowLayoutPanel FlpBonones;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnImprimir;
    }
}