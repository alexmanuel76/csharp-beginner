namespace MiPrimeraConexionConSqlserver
{
    partial class FrmLogin
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
            this.LblLogin = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCacelar = new System.Windows.Forms.Button();
            this.ControlError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ControlError)).BeginInit();
            this.SuspendLayout();
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.Location = new System.Drawing.Point(60, 68);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(43, 17);
            this.LblLogin.TabIndex = 0;
            this.LblLogin.Text = "Login";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(60, 128);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(69, 17);
            this.LblPassword.TabIndex = 1;
            this.LblPassword.Text = "Password";
            // 
            // TxtLogin
            // 
            this.TxtLogin.Location = new System.Drawing.Point(152, 62);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(135, 22);
            this.TxtLogin.TabIndex = 2;
            this.TxtLogin.Tag = "O";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(152, 123);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(135, 22);
            this.TxtPassword.TabIndex = 3;
            this.TxtPassword.Tag = "O";
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAceptar.Location = new System.Drawing.Point(63, 225);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(102, 35);
            this.BtnAceptar.TabIndex = 4;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCacelar
            // 
            this.BtnCacelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCacelar.Location = new System.Drawing.Point(185, 225);
            this.BtnCacelar.Name = "BtnCacelar";
            this.BtnCacelar.Size = new System.Drawing.Size(102, 35);
            this.BtnCacelar.TabIndex = 5;
            this.BtnCacelar.Text = "Cancelar";
            this.BtnCacelar.UseVisualStyleBackColor = true;
            this.BtnCacelar.Click += new System.EventHandler(this.BtnCacelar_Click);
            // 
            // ControlError
            // 
            this.ControlError.ContainerControl = this;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 345);
            this.Controls.Add(this.BtnCacelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtLogin);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblLogin);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.ControlError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCacelar;
        private System.Windows.Forms.ErrorProvider ControlError;
    }
}