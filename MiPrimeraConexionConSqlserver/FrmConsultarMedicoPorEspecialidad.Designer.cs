namespace MiPrimeraConexionConSqlserver
{
    partial class FrmConsultarMedicoPorEspecialidad
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
            this.LblEspecialidad = new System.Windows.Forms.Label();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.DgvMedico = new System.Windows.Forms.DataGridView();
            this.CboEspecialidad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // LblEspecialidad
            // 
            this.LblEspecialidad.AutoSize = true;
            this.LblEspecialidad.Location = new System.Drawing.Point(65, 39);
            this.LblEspecialidad.Name = "LblEspecialidad";
            this.LblEspecialidad.Size = new System.Drawing.Size(139, 17);
            this.LblEspecialidad.TabIndex = 0;
            this.LblEspecialidad.Text = "Ingresa Especialidad";
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(555, 33);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(131, 30);
            this.BtnConsultar.TabIndex = 2;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // DgvMedico
            // 
            this.DgvMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMedico.Location = new System.Drawing.Point(68, 101);
            this.DgvMedico.Name = "DgvMedico";
            this.DgvMedico.RowTemplate.Height = 24;
            this.DgvMedico.Size = new System.Drawing.Size(618, 293);
            this.DgvMedico.TabIndex = 3;
            // 
            // CboEspecialidad
            // 
            this.CboEspecialidad.FormattingEnabled = true;
            this.CboEspecialidad.Location = new System.Drawing.Point(221, 32);
            this.CboEspecialidad.Name = "CboEspecialidad";
            this.CboEspecialidad.Size = new System.Drawing.Size(289, 24);
            this.CboEspecialidad.TabIndex = 4;
            // 
            // FrmConsultarMedicoPorEspecialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CboEspecialidad);
            this.Controls.Add(this.DgvMedico);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.LblEspecialidad);
            this.Name = "FrmConsultarMedicoPorEspecialidad";
            this.Text = "FrmConsultarMedicoPorEspecialidad";
            this.Load += new System.EventHandler(this.FrmConsultarMedicoPorEspecialidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMedico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEspecialidad;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.DataGridView DgvMedico;
        private System.Windows.Forms.ComboBox CboEspecialidad;
    }
}