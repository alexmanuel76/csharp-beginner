namespace MiPrimeraConexionConSqlserver
{
    partial class FrmListadoEspecialidad
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
            this.dtgEspecialidad = new System.Windows.Forms.DataGridView();
            this.LblEspecialidad = new System.Windows.Forms.Label();
            this.TxtNombreEspecialidad = new System.Windows.Forms.TextBox();
            this.FlpBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.PdImpresora = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEspecialidad)).BeginInit();
            this.FlpBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgEspecialidad
            // 
            this.dtgEspecialidad.AllowUserToAddRows = false;
            this.dtgEspecialidad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgEspecialidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEspecialidad.Location = new System.Drawing.Point(43, 127);
            this.dtgEspecialidad.Name = "dtgEspecialidad";
            this.dtgEspecialidad.ReadOnly = true;
            this.dtgEspecialidad.RowTemplate.Height = 24;
            this.dtgEspecialidad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgEspecialidad.Size = new System.Drawing.Size(704, 303);
            this.dtgEspecialidad.TabIndex = 0;
            // 
            // LblEspecialidad
            // 
            this.LblEspecialidad.AutoSize = true;
            this.LblEspecialidad.Location = new System.Drawing.Point(45, 71);
            this.LblEspecialidad.Name = "LblEspecialidad";
            this.LblEspecialidad.Size = new System.Drawing.Size(134, 17);
            this.LblEspecialidad.TabIndex = 1;
            this.LblEspecialidad.Text = "Nombre Especialida";
            // 
            // TxtNombreEspecialidad
            // 
            this.TxtNombreEspecialidad.Location = new System.Drawing.Point(185, 68);
            this.TxtNombreEspecialidad.Name = "TxtNombreEspecialidad";
            this.TxtNombreEspecialidad.Size = new System.Drawing.Size(268, 22);
            this.TxtNombreEspecialidad.TabIndex = 2;
            this.TxtNombreEspecialidad.TextChanged += new System.EventHandler(this.filtrarEspecialidad);
            // 
            // FlpBotones
            // 
            this.FlpBotones.Controls.Add(this.BtnNuevo);
            this.FlpBotones.Controls.Add(this.BtnEliminar);
            this.FlpBotones.Controls.Add(this.BtnEditar);
            this.FlpBotones.Controls.Add(this.BtnImprimir);
            this.FlpBotones.Location = new System.Drawing.Point(4, 4);
            this.FlpBotones.Name = "FlpBotones";
            this.FlpBotones.Size = new System.Drawing.Size(790, 47);
            this.FlpBotones.TabIndex = 3;
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
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
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
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // FrmListadoEspecialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FlpBotones);
            this.Controls.Add(this.TxtNombreEspecialidad);
            this.Controls.Add(this.LblEspecialidad);
            this.Controls.Add(this.dtgEspecialidad);
            this.Name = "FrmListadoEspecialidad";
            this.Text = "Listado Especialidad";
            this.Load += new System.EventHandler(this.FrmListadoEspecialidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEspecialidad)).EndInit();
            this.FlpBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgEspecialidad;
        private System.Windows.Forms.Label LblEspecialidad;
        private System.Windows.Forms.TextBox TxtNombreEspecialidad;
        private System.Windows.Forms.FlowLayoutPanel FlpBotones;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Drawing.Printing.PrintDocument PdImpresora;
    }
}