using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimeraConexionConSqlserver
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            DataTable valores = null;
            string usuario = TxtLogin.Text;
            string pwd = TxtPassword.Text;
            string password = Cifrador.CifrarClaves(pwd);

            bool exito = SQL.validarRequeridos(this.Controls, ControlError);
            if (!exito)
            {
                this.DialogResult = DialogResult.None;
                return;
            }

            valores = SQL.ejecutarSPConsulta("spLogin", new ArrayList { "@i_usuario", "@i_password" }, new ArrayList { usuario, password });
            resultado = valores.Rows.Count;

            if (resultado.Equals(1))
            {
                MessageBox.Show("Bienvenid@: " + usuario, "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmMenu menu = new FrmMenu();
                menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario/Clave Erronea", "Login", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                TxtLogin.Text = "";
                TxtPassword.Text = "";
            }
        }

        private void BtnCacelar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
