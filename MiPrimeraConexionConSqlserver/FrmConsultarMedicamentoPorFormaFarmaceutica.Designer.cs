namespace MiPrimeraConexionConSqlserver
{
    partial class FrmConsultarMedicamentoPorFormaFarmaceutica
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
            this.LblFormaFarmaceutica = new System.Windows.Forms.Label();
            this.CboFormaFarmaceutica = new System.Windows.Forms.ComboBox();
            this.dtgMedicamentosPorForma = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicamentosPorForma)).BeginInit();
            this.SuspendLayout();
            // 
            // LblFormaFarmaceutica
            // 
            this.LblFormaFarmaceutica.AutoSize = true;
            this.LblFormaFarmaceutica.Location = new System.Drawing.Point(56, 25);
            this.LblFormaFarmaceutica.Name = "LblFormaFarmaceutica";
            this.LblFormaFarmaceutica.Size = new System.Drawing.Size(184, 17);
            this.LblFormaFarmaceutica.TabIndex = 0;
            this.LblFormaFarmaceutica.Text = "Infrese Forma Farmaceutica";
            // 
            // CboFormaFarmaceutica
            // 
            this.CboFormaFarmaceutica.FormattingEnabled = true;
            this.CboFormaFarmaceutica.Location = new System.Drawing.Point(246, 18);
            this.CboFormaFarmaceutica.Name = "CboFormaFarmaceutica";
            this.CboFormaFarmaceutica.Size = new System.Drawing.Size(294, 24);
            this.CboFormaFarmaceutica.TabIndex = 1;
            this.CboFormaFarmaceutica.SelectionChangeCommitted += new System.EventHandler(this.filtrar);
            // 
            // dtgMedicamentosPorForma
            // 
            this.dtgMedicamentosPorForma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMedicamentosPorForma.Location = new System.Drawing.Point(59, 101);
            this.dtgMedicamentosPorForma.Name = "dtgMedicamentosPorForma";
            this.dtgMedicamentosPorForma.RowTemplate.Height = 24;
            this.dtgMedicamentosPorForma.Size = new System.Drawing.Size(639, 249);
            this.dtgMedicamentosPorForma.TabIndex = 2;
            // 
            // FrmConsultarMedicamentoPorFormaFarmaceutica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgMedicamentosPorForma);
            this.Controls.Add(this.CboFormaFarmaceutica);
            this.Controls.Add(this.LblFormaFarmaceutica);
            this.Name = "FrmConsultarMedicamentoPorFormaFarmaceutica";
            this.Text = "Consultar Medicamento Por Forma Farmaceutica";
            this.Load += new System.EventHandler(this.FrmConsultarMedicamentoPorFormaFarmaceutica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicamentosPorForma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFormaFarmaceutica;
        private System.Windows.Forms.ComboBox CboFormaFarmaceutica;
        private System.Windows.Forms.DataGridView dtgMedicamentosPorForma;
    }
}