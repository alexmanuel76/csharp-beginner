namespace MiPrimeraConexionConSqlserver
{
    partial class FrmClinicas
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
            this.dtgClinica = new System.Windows.Forms.DataGridView();
            this.LblClinica = new System.Windows.Forms.Label();
            this.txtIdClinica = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.FlpBonones = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.PdImpresora = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClinica)).BeginInit();
            this.FlpBonones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgClinica
            // 
            this.dtgClinica.AllowUserToAddRows = false;
            this.dtgClinica.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgClinica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClinica.Location = new System.Drawing.Point(86, 116);
            this.dtgClinica.Name = "dtgClinica";
            this.dtgClinica.ReadOnly = true;
            this.dtgClinica.RowTemplate.Height = 24;
            this.dtgClinica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgClinica.Size = new System.Drawing.Size(616, 290);
            this.dtgClinica.TabIndex = 0;
            // 
            // LblClinica
            // 
            this.LblClinica.AutoSize = true;
            this.LblClinica.Location = new System.Drawing.Point(86, 77);
            this.LblClinica.Name = "LblClinica";
            this.LblClinica.Size = new System.Drawing.Size(66, 17);
            this.LblClinica.TabIndex = 1;
            this.LblClinica.Text = "ID Clinica";
            // 
            // txtIdClinica
            // 
            this.txtIdClinica.Location = new System.Drawing.Point(158, 77);
            this.txtIdClinica.Name = "txtIdClinica";
            this.txtIdClinica.Size = new System.Drawing.Size(175, 22);
            this.txtIdClinica.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(421, 70);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(106, 37);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(544, 70);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(103, 37);
            this.BtnLimpiar.TabIndex = 4;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // FlpBonones
            // 
            this.FlpBonones.Controls.Add(this.BtnNuevo);
            this.FlpBonones.Controls.Add(this.BtnEditar);
            this.FlpBonones.Controls.Add(this.BtnEliminar);
            this.FlpBonones.Controls.Add(this.BtnImprimir);
            this.FlpBonones.Location = new System.Drawing.Point(4, 4);
            this.FlpBonones.Name = "FlpBonones";
            this.FlpBonones.Size = new System.Drawing.Size(793, 46);
            this.FlpBonones.TabIndex = 5;
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
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // PdImpresora
            // 
            // 
            // FrmClinicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FlpBonones);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtIdClinica);
            this.Controls.Add(this.LblClinica);
            this.Controls.Add(this.dtgClinica);
            this.Name = "FrmClinicas";
            this.Text = "Listado de Clinicas";
            this.Load += new System.EventHandler(this.Formulario1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgClinica)).EndInit();
            this.FlpBonones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgClinica;
        private System.Windows.Forms.Label LblClinica;
        private System.Windows.Forms.TextBox txtIdClinica;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.FlowLayoutPanel FlpBonones;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Drawing.Printing.PrintDocument PdImpresora;
    }
}

