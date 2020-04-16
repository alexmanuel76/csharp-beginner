namespace MiPrimeraConexionConSqlserver
{
    partial class FrmPopupPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPopupPacientes));
            this.LblIdPaciente = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblMaterno = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.LblCelular = new System.Windows.Forms.Label();
            this.LblFechaNacimiento = new System.Windows.Forms.Label();
            this.LblSexo = new System.Windows.Forms.Label();
            this.LblTipoSangre = new System.Windows.Forms.Label();
            this.LblAlergias = new System.Windows.Forms.Label();
            this.LblEnfermedades = new System.Windows.Forms.Label();
            this.LblVacunas = new System.Windows.Forms.Label();
            this.LblAntecendentes = new System.Windows.Forms.Label();
            this.TxtIdPaciente = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.TxtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtCelular = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtAlergias = new System.Windows.Forms.TextBox();
            this.TxtEnfermedades = new System.Windows.Forms.TextBox();
            this.TxtVacunas = new System.Windows.Forms.TextBox();
            this.TxtAntecedentes = new System.Windows.Forms.TextBox();
            this.CboSexo = new System.Windows.Forms.ComboBox();
            this.LblFoto = new System.Windows.Forms.Label();
            this.PbFfoto = new System.Windows.Forms.PictureBox();
            this.BtnFoto = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.DtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.CboTipoSangre = new System.Windows.Forms.ComboBox();
            this.ControlErrores = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PbFfoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // LblIdPaciente
            // 
            this.LblIdPaciente.AutoSize = true;
            this.LblIdPaciente.Location = new System.Drawing.Point(69, 16);
            this.LblIdPaciente.Name = "LblIdPaciente";
            this.LblIdPaciente.Size = new System.Drawing.Size(80, 17);
            this.LblIdPaciente.TabIndex = 0;
            this.LblIdPaciente.Text = "ID Paciente";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(69, 68);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(58, 17);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Nombre";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Location = new System.Drawing.Point(443, 68);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(112, 17);
            this.LblApellido.TabIndex = 2;
            this.LblApellido.Text = "Apellido Paterno";
            // 
            // LblMaterno
            // 
            this.LblMaterno.AutoSize = true;
            this.LblMaterno.Location = new System.Drawing.Point(69, 120);
            this.LblMaterno.Name = "LblMaterno";
            this.LblMaterno.Size = new System.Drawing.Size(114, 17);
            this.LblMaterno.TabIndex = 3;
            this.LblMaterno.Text = "Apellido Materno";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(443, 120);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(42, 17);
            this.LblEmail.TabIndex = 4;
            this.LblEmail.Text = "Email";
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Location = new System.Drawing.Point(69, 172);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(67, 17);
            this.LblDireccion.TabIndex = 5;
            this.LblDireccion.Text = "Direccion";
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Location = new System.Drawing.Point(443, 172);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(90, 17);
            this.LblTelefono.TabIndex = 6;
            this.LblTelefono.Text = "Telefono Fijo";
            // 
            // LblCelular
            // 
            this.LblCelular.AutoSize = true;
            this.LblCelular.Location = new System.Drawing.Point(69, 224);
            this.LblCelular.Name = "LblCelular";
            this.LblCelular.Size = new System.Drawing.Size(112, 17);
            this.LblCelular.TabIndex = 7;
            this.LblCelular.Text = "Telefono Celular";
            // 
            // LblFechaNacimiento
            // 
            this.LblFechaNacimiento.AutoSize = true;
            this.LblFechaNacimiento.Location = new System.Drawing.Point(443, 224);
            this.LblFechaNacimiento.Name = "LblFechaNacimiento";
            this.LblFechaNacimiento.Size = new System.Drawing.Size(141, 17);
            this.LblFechaNacimiento.TabIndex = 8;
            this.LblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // LblSexo
            // 
            this.LblSexo.AutoSize = true;
            this.LblSexo.Location = new System.Drawing.Point(69, 276);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.Size = new System.Drawing.Size(39, 17);
            this.LblSexo.TabIndex = 9;
            this.LblSexo.Text = "Sexo";
            // 
            // LblTipoSangre
            // 
            this.LblTipoSangre.AutoSize = true;
            this.LblTipoSangre.Location = new System.Drawing.Point(443, 276);
            this.LblTipoSangre.Name = "LblTipoSangre";
            this.LblTipoSangre.Size = new System.Drawing.Size(106, 17);
            this.LblTipoSangre.TabIndex = 10;
            this.LblTipoSangre.Text = "Tipo de Sangre";
            // 
            // LblAlergias
            // 
            this.LblAlergias.AutoSize = true;
            this.LblAlergias.Location = new System.Drawing.Point(69, 328);
            this.LblAlergias.Name = "LblAlergias";
            this.LblAlergias.Size = new System.Drawing.Size(59, 17);
            this.LblAlergias.TabIndex = 11;
            this.LblAlergias.Text = "Alergias";
            // 
            // LblEnfermedades
            // 
            this.LblEnfermedades.AutoSize = true;
            this.LblEnfermedades.Location = new System.Drawing.Point(443, 328);
            this.LblEnfermedades.Name = "LblEnfermedades";
            this.LblEnfermedades.Size = new System.Drawing.Size(100, 17);
            this.LblEnfermedades.TabIndex = 12;
            this.LblEnfermedades.Text = "Enfermedades";
            // 
            // LblVacunas
            // 
            this.LblVacunas.AutoSize = true;
            this.LblVacunas.Location = new System.Drawing.Point(69, 380);
            this.LblVacunas.Name = "LblVacunas";
            this.LblVacunas.Size = new System.Drawing.Size(63, 17);
            this.LblVacunas.TabIndex = 13;
            this.LblVacunas.Text = "Vacunas";
            // 
            // LblAntecendentes
            // 
            this.LblAntecendentes.AutoSize = true;
            this.LblAntecendentes.Location = new System.Drawing.Point(443, 380);
            this.LblAntecendentes.Name = "LblAntecendentes";
            this.LblAntecendentes.Size = new System.Drawing.Size(95, 17);
            this.LblAntecendentes.TabIndex = 14;
            this.LblAntecendentes.Text = "Antecedentes";
            // 
            // TxtIdPaciente
            // 
            this.TxtIdPaciente.Location = new System.Drawing.Point(193, 16);
            this.TxtIdPaciente.Name = "TxtIdPaciente";
            this.TxtIdPaciente.ReadOnly = true;
            this.TxtIdPaciente.Size = new System.Drawing.Size(135, 22);
            this.TxtIdPaciente.TabIndex = 15;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(193, 63);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(207, 22);
            this.TxtNombre.TabIndex = 16;
            this.TxtNombre.Tag = "O";
            // 
            // TxtApellidoPaterno
            // 
            this.TxtApellidoPaterno.Location = new System.Drawing.Point(599, 63);
            this.TxtApellidoPaterno.Name = "TxtApellidoPaterno";
            this.TxtApellidoPaterno.Size = new System.Drawing.Size(222, 22);
            this.TxtApellidoPaterno.TabIndex = 17;
            this.TxtApellidoPaterno.Tag = "O";
            // 
            // TxtApellidoMaterno
            // 
            this.TxtApellidoMaterno.Location = new System.Drawing.Point(193, 117);
            this.TxtApellidoMaterno.Name = "TxtApellidoMaterno";
            this.TxtApellidoMaterno.Size = new System.Drawing.Size(207, 22);
            this.TxtApellidoMaterno.TabIndex = 18;
            this.TxtApellidoMaterno.Tag = "O";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(599, 115);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(222, 22);
            this.TxtEmail.TabIndex = 19;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(193, 167);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(207, 22);
            this.TxtDireccion.TabIndex = 20;
            // 
            // TxtCelular
            // 
            this.TxtCelular.Location = new System.Drawing.Point(193, 219);
            this.TxtCelular.Name = "TxtCelular";
            this.TxtCelular.Size = new System.Drawing.Size(135, 22);
            this.TxtCelular.TabIndex = 21;
            this.TxtCelular.Tag = "O";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(599, 167);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(135, 22);
            this.TxtTelefono.TabIndex = 23;
            // 
            // TxtAlergias
            // 
            this.TxtAlergias.Location = new System.Drawing.Point(193, 323);
            this.TxtAlergias.Name = "TxtAlergias";
            this.TxtAlergias.Size = new System.Drawing.Size(207, 22);
            this.TxtAlergias.TabIndex = 24;
            this.TxtAlergias.Tag = "O";
            // 
            // TxtEnfermedades
            // 
            this.TxtEnfermedades.Location = new System.Drawing.Point(599, 325);
            this.TxtEnfermedades.Name = "TxtEnfermedades";
            this.TxtEnfermedades.Size = new System.Drawing.Size(222, 22);
            this.TxtEnfermedades.TabIndex = 25;
            this.TxtEnfermedades.Tag = "O";
            // 
            // TxtVacunas
            // 
            this.TxtVacunas.Location = new System.Drawing.Point(193, 375);
            this.TxtVacunas.Name = "TxtVacunas";
            this.TxtVacunas.Size = new System.Drawing.Size(207, 22);
            this.TxtVacunas.TabIndex = 26;
            this.TxtVacunas.Tag = "O";
            // 
            // TxtAntecedentes
            // 
            this.TxtAntecedentes.Location = new System.Drawing.Point(599, 375);
            this.TxtAntecedentes.Name = "TxtAntecedentes";
            this.TxtAntecedentes.Size = new System.Drawing.Size(135, 22);
            this.TxtAntecedentes.TabIndex = 27;
            // 
            // CboSexo
            // 
            this.CboSexo.FormattingEnabled = true;
            this.CboSexo.Location = new System.Drawing.Point(193, 267);
            this.CboSexo.Name = "CboSexo";
            this.CboSexo.Size = new System.Drawing.Size(165, 24);
            this.CboSexo.TabIndex = 28;
            this.CboSexo.Tag = "O";
            // 
            // LblFoto
            // 
            this.LblFoto.AutoSize = true;
            this.LblFoto.Location = new System.Drawing.Point(72, 446);
            this.LblFoto.Name = "LblFoto";
            this.LblFoto.Size = new System.Drawing.Size(36, 17);
            this.LblFoto.TabIndex = 30;
            this.LblFoto.Text = "Foto";
            // 
            // PbFfoto
            // 
            this.PbFfoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbFfoto.Location = new System.Drawing.Point(193, 446);
            this.PbFfoto.Name = "PbFfoto";
            this.PbFfoto.Size = new System.Drawing.Size(184, 125);
            this.PbFfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbFfoto.TabIndex = 31;
            this.PbFfoto.TabStop = false;
            // 
            // BtnFoto
            // 
            this.BtnFoto.Location = new System.Drawing.Point(112, 471);
            this.BtnFoto.Name = "BtnFoto";
            this.BtnFoto.Size = new System.Drawing.Size(75, 23);
            this.BtnFoto.TabIndex = 32;
            this.BtnFoto.Text = "...";
            this.BtnFoto.UseVisualStyleBackColor = true;
            this.BtnFoto.Click += new System.EventHandler(this.BtnFoto_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(305, 600);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(119, 36);
            this.BtnAceptar.TabIndex = 33;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(467, 600);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(119, 36);
            this.BtnCancelar.TabIndex = 34;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // DtFechaNacimiento
            // 
            this.DtFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtFechaNacimiento.Location = new System.Drawing.Point(599, 218);
            this.DtFechaNacimiento.MaxDate = new System.DateTime(2110, 12, 31, 0, 0, 0, 0);
            this.DtFechaNacimiento.Name = "DtFechaNacimiento";
            this.DtFechaNacimiento.Size = new System.Drawing.Size(135, 22);
            this.DtFechaNacimiento.TabIndex = 35;
            this.DtFechaNacimiento.Value = new System.DateTime(2020, 4, 9, 0, 0, 0, 0);
            // 
            // CboTipoSangre
            // 
            this.CboTipoSangre.FormattingEnabled = true;
            this.CboTipoSangre.Location = new System.Drawing.Point(599, 267);
            this.CboTipoSangre.Name = "CboTipoSangre";
            this.CboTipoSangre.Size = new System.Drawing.Size(135, 24);
            this.CboTipoSangre.TabIndex = 36;
            this.CboTipoSangre.Tag = "O";
            // 
            // ControlErrores
            // 
            this.ControlErrores.ContainerControl = this;
            // 
            // FrmPopupPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 689);
            this.Controls.Add(this.CboTipoSangre);
            this.Controls.Add(this.DtFechaNacimiento);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.BtnFoto);
            this.Controls.Add(this.PbFfoto);
            this.Controls.Add(this.LblFoto);
            this.Controls.Add(this.CboSexo);
            this.Controls.Add(this.TxtAntecedentes);
            this.Controls.Add(this.TxtVacunas);
            this.Controls.Add(this.TxtEnfermedades);
            this.Controls.Add(this.TxtAlergias);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.TxtCelular);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtApellidoMaterno);
            this.Controls.Add(this.TxtApellidoPaterno);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtIdPaciente);
            this.Controls.Add(this.LblAntecendentes);
            this.Controls.Add(this.LblVacunas);
            this.Controls.Add(this.LblEnfermedades);
            this.Controls.Add(this.LblAlergias);
            this.Controls.Add(this.LblTipoSangre);
            this.Controls.Add(this.LblSexo);
            this.Controls.Add(this.LblFechaNacimiento);
            this.Controls.Add(this.LblCelular);
            this.Controls.Add(this.LblTelefono);
            this.Controls.Add(this.LblDireccion);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblMaterno);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblIdPaciente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPopupPacientes";
            this.Text = "FrmPopupPacientes";
            this.Load += new System.EventHandler(this.FrmPopupPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbFfoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlErrores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblIdPaciente;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblMaterno;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.Label LblCelular;
        private System.Windows.Forms.Label LblFechaNacimiento;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.Label LblTipoSangre;
        private System.Windows.Forms.Label LblAlergias;
        private System.Windows.Forms.Label LblEnfermedades;
        private System.Windows.Forms.Label LblVacunas;
        private System.Windows.Forms.Label LblAntecendentes;
        private System.Windows.Forms.TextBox TxtIdPaciente;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellidoPaterno;
        private System.Windows.Forms.TextBox TxtApellidoMaterno;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtCelular;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtAlergias;
        private System.Windows.Forms.TextBox TxtEnfermedades;
        private System.Windows.Forms.TextBox TxtVacunas;
        private System.Windows.Forms.TextBox TxtAntecedentes;
        private System.Windows.Forms.ComboBox CboSexo;
        private System.Windows.Forms.Label LblFoto;
        private System.Windows.Forms.PictureBox PbFfoto;
        private System.Windows.Forms.Button BtnFoto;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.DateTimePicker DtFechaNacimiento;
        private System.Windows.Forms.ComboBox CboTipoSangre;
        private System.Windows.Forms.ErrorProvider ControlErrores;
    }
}