using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace MiPrimeraConexionConSqlserver
{
    public partial class FrmClinicas : Form
    {
        public FrmClinicas()
        {
            InitializeComponent();
        }

        private void Formulario1_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Object[] parametrosSQL = new Object[2];
            parametrosSQL[0] = "@i_idClinica";
            parametrosSQL[1] = txtIdClinica.Text;
            HashSet<Object> datosSQL = new HashSet<Object>();
            datosSQL.Add(parametrosSQL);

            SQL.ejeutarSpParametros("sp_buscarClinicaPorId", dtgClinica, datosSQL);
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            listar();
            txtIdClinica.Text = "";
        }

        private void listar()
        {
            SQL.listarConsultaSql("select IIDCLINICA CLINICA,NOMBRE,DIRECCION from Clinica where BHABILITADO = 1", dtgClinica, false);
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmPopupClinica frmPopupClinica = new FrmPopupClinica();
            frmPopupClinica.accion = "Nuevo";
            frmPopupClinica.ShowDialog();
            if (frmPopupClinica.DialogResult.Equals(DialogResult.OK))
            {
                listar();
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            FrmPopupClinica frmPopupClinica = new FrmPopupClinica();
            frmPopupClinica.accion = "Editar";
            frmPopupClinica.id = dtgClinica.CurrentRow.Cells[0].Value.ToString();
            frmPopupClinica.ShowDialog();
            if (frmPopupClinica.DialogResult.Equals(DialogResult.OK))
            {
                listar();
            }
        }
    }
}
