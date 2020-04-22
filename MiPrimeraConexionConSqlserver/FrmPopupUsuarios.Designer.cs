namespace MiPrimeraConexionConSqlserver
{
    partial class FrmPopupUsuarios
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
            this.LblDoctor = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblPwd1 = new System.Windows.Forms.Label();
            this.LblPwd2 = new System.Windows.Forms.Label();
            this.CboDoctor = new System.Windows.Forms.ComboBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtPassword1 = new System.Windows.Forms.TextBox();
            this.TxtPassword2 = new System.Windows.Forms.TextBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.ManejoErrores = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ManejoErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // LblDoctor
            // 
            this.LblDoctor.AutoSize = true;
            this.LblDoctor.Location = new System.Drawing.Point(34, 51);
            this.LblDoctor.Name = "LblDoctor";
            this.LblDoctor.Size = new System.Drawing.Size(123, 17);
            this.LblDoctor.TabIndex = 0;
            this.LblDoctor.Text = "Seleccione Doctor";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(34, 103);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(57, 17);
            this.LblUsuario.TabIndex = 1;
            this.LblUsuario.Text = "Usuario";
            // 
            // LblPwd1
            // 
            this.LblPwd1.AutoSize = true;
            this.LblPwd1.Location = new System.Drawing.Point(34, 166);
            this.LblPwd1.Name = "LblPwd1";
            this.LblPwd1.Size = new System.Drawing.Size(69, 17);
            this.LblPwd1.TabIndex = 2;
            this.LblPwd1.Text = "Password";
            // 
            // LblPwd2
            // 
            this.LblPwd2.AutoSize = true;
            this.LblPwd2.Location = new System.Drawing.Point(34, 228);
            this.LblPwd2.Name = "LblPwd2";
            this.LblPwd2.Size = new System.Drawing.Size(129, 17);
            this.LblPwd2.TabIndex = 3;
            this.LblPwd2.Text = "Confirme Password";
            // 
            // CboDoctor
            // 
            this.CboDoctor.FormattingEnabled = true;
            this.CboDoctor.Location = new System.Drawing.Point(166, 42);
            this.CboDoctor.Name = "CboDoctor";
            this.CboDoctor.Size = new System.Drawing.Size(235, 24);
            this.CboDoctor.TabIndex = 4;
            this.CboDoctor.Tag = "O";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(166, 97);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(211, 22);
            this.TxtUsuario.TabIndex = 5;
            this.TxtUsuario.Tag = "O";
            // 
            // TxtPassword1
            // 
            this.TxtPassword1.Location = new System.Drawing.Point(166, 161);
            this.TxtPassword1.Name = "TxtPassword1";
            this.TxtPassword1.Size = new System.Drawing.Size(211, 22);
            this.TxtPassword1.TabIndex = 6;
            this.TxtPassword1.Tag = "O";
            this.TxtPassword1.UseSystemPasswordChar = true;
            // 
            // TxtPassword2
            // 
            this.TxtPassword2.Location = new System.Drawing.Point(166, 223);
            this.TxtPassword2.Name = "TxtPassword2";
            this.TxtPassword2.Size = new System.Drawing.Size(211, 22);
            this.TxtPassword2.TabIndex = 7;
            this.TxtPassword2.Tag = "O";
            this.TxtPassword2.UseSystemPasswordChar = true;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAceptar.Location = new System.Drawing.Point(74, 309);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(128, 36);
            this.BtnAceptar.TabIndex = 8;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Location = new System.Drawing.Point(226, 309);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(128, 36);
            this.BtnCancelar.TabIndex = 9;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // ManejoErrores
            // 
            this.ManejoErrores.ContainerControl = this;
            // 
            // FrmPopupUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 418);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.TxtPassword2);
            this.Controls.Add(this.TxtPassword1);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.CboDoctor);
            this.Controls.Add(this.LblPwd2);
            this.Controls.Add(this.LblPwd1);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.LblDoctor);
            this.Name = "FrmPopupUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.FrmPopupUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ManejoErrores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDoctor;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblPwd1;
        private System.Windows.Forms.Label LblPwd2;
        private System.Windows.Forms.ComboBox CboDoctor;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtPassword1;
        private System.Windows.Forms.TextBox TxtPassword2;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.ErrorProvider ManejoErrores;
    }
}