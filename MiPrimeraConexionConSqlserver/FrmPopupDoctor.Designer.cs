namespace MiPrimeraConexionConSqlserver
{
    partial class FrmPopupDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPopupDoctor));
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblApellidoPaterno = new System.Windows.Forms.Label();
            this.LblApellidoMaterno = new System.Windows.Forms.Label();
            this.LblClinica = new System.Windows.Forms.Label();
            this.LblEspecialidad = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblCelular = new System.Windows.Forms.Label();
            this.LblSexo = new System.Windows.Forms.Label();
            this.LblSueldo = new System.Windows.Forms.Label();
            this.LblFechaContrato = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApePaterno = new System.Windows.Forms.TextBox();
            this.TxtApeMaterno = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.CboClinica = new System.Windows.Forms.ComboBox();
            this.CboEspecialidad = new System.Windows.Forms.ComboBox();
            this.CboSexo = new System.Windows.Forms.ComboBox();
            this.NumSueldo = new System.Windows.Forms.NumericUpDown();
            this.DtFechaContrato = new System.Windows.Forms.DateTimePicker();
            this.BtnArchivo = new System.Windows.Forms.Button();
            this.WbArchivo = new System.Windows.Forms.WebBrowser();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.ControlDeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.LbIdDoctor = new System.Windows.Forms.Label();
            this.TxtIdDoctor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumSueldo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlDeError)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(57, 74);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(58, 17);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Nombre";
            // 
            // LblApellidoPaterno
            // 
            this.LblApellidoPaterno.AutoSize = true;
            this.LblApellidoPaterno.Location = new System.Drawing.Point(462, 74);
            this.LblApellidoPaterno.Name = "LblApellidoPaterno";
            this.LblApellidoPaterno.Size = new System.Drawing.Size(112, 17);
            this.LblApellidoPaterno.TabIndex = 1;
            this.LblApellidoPaterno.Text = "Apellido Paterno";
            // 
            // LblApellidoMaterno
            // 
            this.LblApellidoMaterno.AutoSize = true;
            this.LblApellidoMaterno.Location = new System.Drawing.Point(57, 148);
            this.LblApellidoMaterno.Name = "LblApellidoMaterno";
            this.LblApellidoMaterno.Size = new System.Drawing.Size(114, 17);
            this.LblApellidoMaterno.TabIndex = 2;
            this.LblApellidoMaterno.Text = "Apellido Materno";
            // 
            // LblClinica
            // 
            this.LblClinica.AutoSize = true;
            this.LblClinica.Location = new System.Drawing.Point(462, 148);
            this.LblClinica.Name = "LblClinica";
            this.LblClinica.Size = new System.Drawing.Size(49, 17);
            this.LblClinica.TabIndex = 3;
            this.LblClinica.Text = "Clinica";
            // 
            // LblEspecialidad
            // 
            this.LblEspecialidad.AutoSize = true;
            this.LblEspecialidad.Location = new System.Drawing.Point(57, 222);
            this.LblEspecialidad.Name = "LblEspecialidad";
            this.LblEspecialidad.Size = new System.Drawing.Size(88, 17);
            this.LblEspecialidad.TabIndex = 4;
            this.LblEspecialidad.Text = "Especialidad";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(462, 222);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(42, 17);
            this.LblEmail.TabIndex = 5;
            this.LblEmail.Text = "Email";
            // 
            // LblCelular
            // 
            this.LblCelular.AutoSize = true;
            this.LblCelular.Location = new System.Drawing.Point(57, 296);
            this.LblCelular.Name = "LblCelular";
            this.LblCelular.Size = new System.Drawing.Size(112, 17);
            this.LblCelular.TabIndex = 6;
            this.LblCelular.Text = "Telefono Celular";
            // 
            // LblSexo
            // 
            this.LblSexo.AutoSize = true;
            this.LblSexo.Location = new System.Drawing.Point(462, 296);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.Size = new System.Drawing.Size(39, 17);
            this.LblSexo.TabIndex = 7;
            this.LblSexo.Text = "Sexo";
            // 
            // LblSueldo
            // 
            this.LblSueldo.AutoSize = true;
            this.LblSueldo.Location = new System.Drawing.Point(57, 370);
            this.LblSueldo.Name = "LblSueldo";
            this.LblSueldo.Size = new System.Drawing.Size(52, 17);
            this.LblSueldo.TabIndex = 8;
            this.LblSueldo.Text = "Sueldo";
            // 
            // LblFechaContrato
            // 
            this.LblFechaContrato.AutoSize = true;
            this.LblFechaContrato.Location = new System.Drawing.Point(462, 370);
            this.LblFechaContrato.Name = "LblFechaContrato";
            this.LblFechaContrato.Size = new System.Drawing.Size(105, 17);
            this.LblFechaContrato.TabIndex = 9;
            this.LblFechaContrato.Text = "Fecha Contrato";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(61, 444);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Archivo";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(185, 68);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(201, 22);
            this.TxtNombre.TabIndex = 11;
            this.TxtNombre.Tag = "O";
            // 
            // TxtApePaterno
            // 
            this.TxtApePaterno.Location = new System.Drawing.Point(601, 71);
            this.TxtApePaterno.Name = "TxtApePaterno";
            this.TxtApePaterno.Size = new System.Drawing.Size(201, 22);
            this.TxtApePaterno.TabIndex = 12;
            this.TxtApePaterno.Tag = "O";
            // 
            // TxtApeMaterno
            // 
            this.TxtApeMaterno.Location = new System.Drawing.Point(185, 143);
            this.TxtApeMaterno.Name = "TxtApeMaterno";
            this.TxtApeMaterno.Size = new System.Drawing.Size(201, 22);
            this.TxtApeMaterno.TabIndex = 13;
            this.TxtApeMaterno.Tag = "O";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(601, 217);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(201, 22);
            this.TxtEmail.TabIndex = 14;
            this.TxtEmail.Tag = "";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(185, 293);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(201, 22);
            this.TxtTelefono.TabIndex = 15;
            this.TxtTelefono.Tag = "O";
            // 
            // CboClinica
            // 
            this.CboClinica.FormattingEnabled = true;
            this.CboClinica.Location = new System.Drawing.Point(601, 139);
            this.CboClinica.Name = "CboClinica";
            this.CboClinica.Size = new System.Drawing.Size(201, 24);
            this.CboClinica.TabIndex = 16;
            this.CboClinica.Tag = "O";
            // 
            // CboEspecialidad
            // 
            this.CboEspecialidad.FormattingEnabled = true;
            this.CboEspecialidad.Location = new System.Drawing.Point(185, 213);
            this.CboEspecialidad.Name = "CboEspecialidad";
            this.CboEspecialidad.Size = new System.Drawing.Size(201, 24);
            this.CboEspecialidad.TabIndex = 17;
            this.CboEspecialidad.Tag = "O";
            // 
            // CboSexo
            // 
            this.CboSexo.FormattingEnabled = true;
            this.CboSexo.Location = new System.Drawing.Point(601, 287);
            this.CboSexo.Name = "CboSexo";
            this.CboSexo.Size = new System.Drawing.Size(121, 24);
            this.CboSexo.TabIndex = 18;
            this.CboSexo.Tag = "O";
            // 
            // NumSueldo
            // 
            this.NumSueldo.Location = new System.Drawing.Point(185, 364);
            this.NumSueldo.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NumSueldo.Name = "NumSueldo";
            this.NumSueldo.Size = new System.Drawing.Size(201, 22);
            this.NumSueldo.TabIndex = 19;
            // 
            // DtFechaContrato
            // 
            this.DtFechaContrato.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtFechaContrato.Location = new System.Drawing.Point(601, 363);
            this.DtFechaContrato.Name = "DtFechaContrato";
            this.DtFechaContrato.Size = new System.Drawing.Size(200, 22);
            this.DtFechaContrato.TabIndex = 20;
            // 
            // BtnArchivo
            // 
            this.BtnArchivo.Location = new System.Drawing.Point(185, 473);
            this.BtnArchivo.Name = "BtnArchivo";
            this.BtnArchivo.Size = new System.Drawing.Size(75, 23);
            this.BtnArchivo.TabIndex = 21;
            this.BtnArchivo.Text = "...";
            this.BtnArchivo.UseVisualStyleBackColor = true;
            this.BtnArchivo.Click += new System.EventHandler(this.BtnArchivo_Click);
            // 
            // WbArchivo
            // 
            this.WbArchivo.Location = new System.Drawing.Point(465, 411);
            this.WbArchivo.MinimumSize = new System.Drawing.Size(20, 20);
            this.WbArchivo.Name = "WbArchivo";
            this.WbArchivo.Size = new System.Drawing.Size(336, 182);
            this.WbArchivo.TabIndex = 22;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(270, 628);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(132, 33);
            this.BtnAceptar.TabIndex = 23;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(457, 628);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(132, 33);
            this.BtnCancelar.TabIndex = 24;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // ControlDeError
            // 
            this.ControlDeError.ContainerControl = this;
            // 
            // LbIdDoctor
            // 
            this.LbIdDoctor.AutoSize = true;
            this.LbIdDoctor.Location = new System.Drawing.Point(60, 19);
            this.LbIdDoctor.Name = "LbIdDoctor";
            this.LbIdDoctor.Size = new System.Drawing.Size(67, 17);
            this.LbIdDoctor.TabIndex = 25;
            this.LbIdDoctor.Text = "ID Doctor";
            // 
            // TxtIdDoctor
            // 
            this.TxtIdDoctor.Location = new System.Drawing.Point(185, 16);
            this.TxtIdDoctor.Name = "TxtIdDoctor";
            this.TxtIdDoctor.ReadOnly = true;
            this.TxtIdDoctor.Size = new System.Drawing.Size(100, 22);
            this.TxtIdDoctor.TabIndex = 26;
            // 
            // FrmPopupDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 712);
            this.Controls.Add(this.TxtIdDoctor);
            this.Controls.Add(this.LbIdDoctor);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.WbArchivo);
            this.Controls.Add(this.BtnArchivo);
            this.Controls.Add(this.DtFechaContrato);
            this.Controls.Add(this.NumSueldo);
            this.Controls.Add(this.CboSexo);
            this.Controls.Add(this.CboEspecialidad);
            this.Controls.Add(this.CboClinica);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtApeMaterno);
            this.Controls.Add(this.TxtApePaterno);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.LblFechaContrato);
            this.Controls.Add(this.LblSueldo);
            this.Controls.Add(this.LblSexo);
            this.Controls.Add(this.LblCelular);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblEspecialidad);
            this.Controls.Add(this.LblClinica);
            this.Controls.Add(this.LblApellidoMaterno);
            this.Controls.Add(this.LblApellidoPaterno);
            this.Controls.Add(this.LblNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPopupDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmPopupDoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumSueldo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlDeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblApellidoPaterno;
        private System.Windows.Forms.Label LblApellidoMaterno;
        private System.Windows.Forms.Label LblClinica;
        private System.Windows.Forms.Label LblEspecialidad;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblCelular;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.Label LblSueldo;
        private System.Windows.Forms.Label LblFechaContrato;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApePaterno;
        private System.Windows.Forms.TextBox TxtApeMaterno;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.ComboBox CboClinica;
        private System.Windows.Forms.ComboBox CboEspecialidad;
        private System.Windows.Forms.ComboBox CboSexo;
        private System.Windows.Forms.NumericUpDown NumSueldo;
        private System.Windows.Forms.DateTimePicker DtFechaContrato;
        private System.Windows.Forms.Button BtnArchivo;
        private System.Windows.Forms.WebBrowser WbArchivo;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.ErrorProvider ControlDeError;
        private System.Windows.Forms.TextBox TxtIdDoctor;
        private System.Windows.Forms.Label LbIdDoctor;
    }
}