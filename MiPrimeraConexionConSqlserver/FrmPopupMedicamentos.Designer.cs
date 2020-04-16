namespace MiPrimeraConexionConSqlserver
{
    partial class FrmPopupMedicamentos
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtConcentracion = new System.Windows.Forms.TextBox();
            this.TxtPresentacion = new System.Windows.Forms.TextBox();
            this.NumPrecio = new System.Windows.Forms.NumericUpDown();
            this.CboFormaFarmaceutica = new System.Windows.Forms.ComboBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.ErrControl = new System.Windows.Forms.ErrorProvider(this.components);
            this.NumStock = new System.Windows.Forms.NumericUpDown();
            this.LblIdMedicamento = new System.Windows.Forms.Label();
            this.TxtIdMedicamento = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumStock)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Concentracion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Forma Farmaceutica";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Presentacion";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(226, 68);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(191, 22);
            this.TxtNombre.TabIndex = 6;
            this.TxtNombre.Tag = "O";
            // 
            // TxtConcentracion
            // 
            this.TxtConcentracion.Location = new System.Drawing.Point(226, 119);
            this.TxtConcentracion.Name = "TxtConcentracion";
            this.TxtConcentracion.Size = new System.Drawing.Size(191, 22);
            this.TxtConcentracion.TabIndex = 7;
            this.TxtConcentracion.Tag = "O";
            // 
            // TxtPresentacion
            // 
            this.TxtPresentacion.Location = new System.Drawing.Point(226, 339);
            this.TxtPresentacion.Name = "TxtPresentacion";
            this.TxtPresentacion.Size = new System.Drawing.Size(191, 22);
            this.TxtPresentacion.TabIndex = 9;
            this.TxtPresentacion.Tag = "O";
            // 
            // NumPrecio
            // 
            this.NumPrecio.Location = new System.Drawing.Point(226, 222);
            this.NumPrecio.Name = "NumPrecio";
            this.NumPrecio.Size = new System.Drawing.Size(141, 22);
            this.NumPrecio.TabIndex = 10;
            this.NumPrecio.Tag = "O";
            // 
            // CboFormaFarmaceutica
            // 
            this.CboFormaFarmaceutica.FormattingEnabled = true;
            this.CboFormaFarmaceutica.Location = new System.Drawing.Point(226, 164);
            this.CboFormaFarmaceutica.Name = "CboFormaFarmaceutica";
            this.CboFormaFarmaceutica.Size = new System.Drawing.Size(191, 24);
            this.CboFormaFarmaceutica.TabIndex = 11;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAceptar.Location = new System.Drawing.Point(130, 412);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(95, 29);
            this.BtnAceptar.TabIndex = 12;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Location = new System.Drawing.Point(263, 412);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(95, 29);
            this.BtnCancelar.TabIndex = 13;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // ErrControl
            // 
            this.ErrControl.ContainerControl = this;
            // 
            // NumStock
            // 
            this.NumStock.Location = new System.Drawing.Point(226, 279);
            this.NumStock.Name = "NumStock";
            this.NumStock.Size = new System.Drawing.Size(141, 22);
            this.NumStock.TabIndex = 14;
            this.NumStock.Tag = "O";
            // 
            // LblIdMedicamento
            // 
            this.LblIdMedicamento.AutoSize = true;
            this.LblIdMedicamento.Location = new System.Drawing.Point(55, 20);
            this.LblIdMedicamento.Name = "LblIdMedicamento";
            this.LblIdMedicamento.Size = new System.Drawing.Size(109, 17);
            this.LblIdMedicamento.TabIndex = 15;
            this.LblIdMedicamento.Text = "ID Medicamento";
            // 
            // TxtIdMedicamento
            // 
            this.TxtIdMedicamento.Location = new System.Drawing.Point(226, 14);
            this.TxtIdMedicamento.Name = "TxtIdMedicamento";
            this.TxtIdMedicamento.ReadOnly = true;
            this.TxtIdMedicamento.Size = new System.Drawing.Size(132, 22);
            this.TxtIdMedicamento.TabIndex = 16;
            // 
            // FrmPopupMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 475);
            this.Controls.Add(this.TxtIdMedicamento);
            this.Controls.Add(this.LblIdMedicamento);
            this.Controls.Add(this.NumStock);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.CboFormaFarmaceutica);
            this.Controls.Add(this.NumPrecio);
            this.Controls.Add(this.TxtPresentacion);
            this.Controls.Add(this.TxtConcentracion);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPopupMedicamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPopupMedicamentos";
            this.Load += new System.EventHandler(this.FrmPopupMedicamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtConcentracion;
        private System.Windows.Forms.TextBox TxtPresentacion;
        private System.Windows.Forms.NumericUpDown NumPrecio;
        private System.Windows.Forms.ComboBox CboFormaFarmaceutica;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.ErrorProvider ErrControl;
        private System.Windows.Forms.NumericUpDown NumStock;
        private System.Windows.Forms.TextBox TxtIdMedicamento;
        private System.Windows.Forms.Label LblIdMedicamento;
    }
}