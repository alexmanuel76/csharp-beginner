namespace MiPrimeraConexionConSqlserver
{
    partial class FrmListadoPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoPaciente));
            this.DgvPacientes = new System.Windows.Forms.DataGridView();
            this.LblCriterio = new System.Windows.Forms.Label();
            this.CboOpciones = new System.Windows.Forms.ComboBox();
            this.LblValor = new System.Windows.Forms.Label();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.FlpBonones = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPacientes)).BeginInit();
            this.FlpBonones.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvPacientes
            // 
            this.DgvPacientes.AllowUserToAddRows = false;
            this.DgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPacientes.Location = new System.Drawing.Point(13, 121);
            this.DgvPacientes.Name = "DgvPacientes";
            this.DgvPacientes.ReadOnly = true;
            this.DgvPacientes.RowTemplate.Height = 24;
            this.DgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPacientes.Size = new System.Drawing.Size(877, 325);
            this.DgvPacientes.TabIndex = 0;
            // 
            // LblCriterio
            // 
            this.LblCriterio.AutoSize = true;
            this.LblCriterio.Location = new System.Drawing.Point(17, 79);
            this.LblCriterio.Name = "LblCriterio";
            this.LblCriterio.Size = new System.Drawing.Size(214, 17);
            this.LblCriterio.TabIndex = 1;
            this.LblCriterio.Text = "Seleccione Criterio de Busqueda";
            // 
            // CboOpciones
            // 
            this.CboOpciones.FormattingEnabled = true;
            this.CboOpciones.Items.AddRange(new object[] {
            "Nombre",
            "Apellido Paterno",
            "Apellido Materno"});
            this.CboOpciones.Location = new System.Drawing.Point(237, 76);
            this.CboOpciones.Name = "CboOpciones";
            this.CboOpciones.Size = new System.Drawing.Size(159, 24);
            this.CboOpciones.TabIndex = 2;
            // 
            // LblValor
            // 
            this.LblValor.AutoSize = true;
            this.LblValor.Location = new System.Drawing.Point(424, 78);
            this.LblValor.Name = "LblValor";
            this.LblValor.Size = new System.Drawing.Size(92, 17);
            this.LblValor.TabIndex = 4;
            this.LblValor.Text = "Ingrese Valor";
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(522, 76);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(141, 22);
            this.TxtValor.TabIndex = 5;
            this.TxtValor.Tag = "";
            this.TxtValor.TextChanged += new System.EventHandler(this.Filtrar);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(686, 71);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 29);
            this.BtnLimpiar.TabIndex = 6;
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
            this.FlpBonones.Location = new System.Drawing.Point(0, 6);
            this.FlpBonones.Name = "FlpBonones";
            this.FlpBonones.Size = new System.Drawing.Size(793, 46);
            this.FlpBonones.TabIndex = 7;
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
            // FrmListadoPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 456);
            this.Controls.Add(this.FlpBonones);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.TxtValor);
            this.Controls.Add(this.LblValor);
            this.Controls.Add(this.CboOpciones);
            this.Controls.Add(this.LblCriterio);
            this.Controls.Add(this.DgvPacientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListadoPaciente";
            this.Text = "Listado de Pacientes";
            this.Load += new System.EventHandler(this.FrmListadoPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPacientes)).EndInit();
            this.FlpBonones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvPacientes;
        private System.Windows.Forms.Label LblCriterio;
        private System.Windows.Forms.ComboBox CboOpciones;
        private System.Windows.Forms.Label LblValor;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.FlowLayoutPanel FlpBonones;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnImprimir;
    }
}