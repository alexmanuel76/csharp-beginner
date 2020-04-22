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
    public partial class FrmPopupUsuarios : Form
    {
        public string accion { get; set; }
        public string idUsuario { get; set; }

        public FrmPopupUsuarios()
        {
            InitializeComponent();
        }

        private void FrmPopupUsuarios_Load(object sender, EventArgs e)
        {
            SQL.listarConsultaSql("spListarDoctor2", CboDoctor, true, "IIDDOCTOR", "DOCTOR");
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            string idMedico = CboDoctor.SelectedValue.ToString();
            string nombreUsuario = TxtUsuario.Text;
            string password = "";
            string pwd1 = TxtPassword1.Text;
            string pwd2 = TxtPassword2.Text;
            int resultado = 0;

            if (accion.Equals("Nuevo"))
            {

                bool exito = SQL.validarRequeridos(this.Controls, ManejoErrores);
                if (!exito || !pwd1.Equals(pwd2))
                {
                    this.DialogResult = DialogResult.None;
                    return;
                }
                else
                {
                    password = Cifrador.CifrarClaves(pwd1);
                    resultado = SQL.EjeutarSp("spInsertarUsuario", 
                                               new ArrayList { "@i_id_doctor", "@i_nombre_usuario", "@i_password" },
                                               new ArrayList { idMedico      , nombreUsuario      , password      });
                }
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }

            if (resultado.Equals(1))
            {
                MessageBox.Show("Usuario Ingresado con Exito", "Mantenimiento de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Error al Crear Usuario", "Mantenimiento de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
