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
    public partial class FrmListadoPaciente : Form
    {
        public FrmListadoPaciente()
        {
            InitializeComponent();
        }

        private void FrmListadoPaciente_Load(object sender, EventArgs e)
        {
            CboOpciones.SelectedIndex = 0;
            ListadoGeneral();
        }

        private void ListadoGeneral()
        {
            SQL.listarConsultaSql("spListarPacientesPrograma", DgvPacientes, true);
        }

        private void Filtrar(object sender, EventArgs e)
        {
            if (CboOpciones.SelectedItem.Equals("Nombre"))
            {
                SQL.ejeutarSpParametros("spListarPacientesPrograma", DgvPacientes, "@i_nombre", TxtValor.Text);
            }
            else if (CboOpciones.SelectedItem.Equals("Apellido Paterno"))
            {
                SQL.ejeutarSpParametros("spListarPacientesPrograma", DgvPacientes, "@i_apellido_paterno", TxtValor.Text);
            }
            else
            {
                SQL.ejeutarSpParametros("spListarPacientesPrograma", DgvPacientes, "@i_apellido_materno", TxtValor.Text);
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtValor.Text = "";
            CboOpciones.SelectedIndex = 0;
            ListadoGeneral();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmPopupPacientes frmPopupPacientes = new FrmPopupPacientes();
            frmPopupPacientes.accion = "Nuevo";
            frmPopupPacientes.ShowDialog();
            if (frmPopupPacientes.DialogResult == DialogResult.OK)
            {
                ListadoGeneral();
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            FrmPopupPacientes frmPopupPacientes = new FrmPopupPacientes();
            frmPopupPacientes.accion = "Editar";
            frmPopupPacientes.idPaciente = DgvPacientes.CurrentRow.Cells[0].Value.ToString();
            frmPopupPacientes.ShowDialog();
        }
    }
}
