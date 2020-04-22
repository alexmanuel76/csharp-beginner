using System;
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
    public partial class FrmListadoUsuarios : Form
    {
        public FrmListadoUsuarios()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmPopupUsuarios frmPopupUsuarios = new FrmPopupUsuarios();
            frmPopupUsuarios.Text = "Crear Usuario";
            frmPopupUsuarios.accion = "Nuevo";
            frmPopupUsuarios.ShowDialog();
            if (frmPopupUsuarios.DialogResult.Equals(DialogResult.OK))
            {
                ListarUsuarios();
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            FrmPopupUsuarios frmPopupUsuarios = new FrmPopupUsuarios();
            frmPopupUsuarios.Text = "Editar Usuario";
            frmPopupUsuarios.accion = "Editar";
            frmPopupUsuarios.idUsuario = DgvUsuarios.CurrentRow.Cells[0].Value.ToString();
            frmPopupUsuarios.ShowDialog();
            if (frmPopupUsuarios.DialogResult.Equals(DialogResult.OK))
            {
                ListarUsuarios();
            }
        }

        private void FrmListadoUsuarios_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
        }

        private void ListarUsuarios()
        {
            SQL.listarConsultaSql("spListarUsuarios", DgvUsuarios, true);
        }
    }
}
