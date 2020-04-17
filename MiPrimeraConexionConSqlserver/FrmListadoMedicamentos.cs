﻿using System;
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
    public partial class FrmListadoMedicamentos : Form
    {
        public FrmListadoMedicamentos()
        {
            InitializeComponent();
        }

        private void FrmListadoMedicamentos_Load(object sender, EventArgs e)
        {
            RbNombre.Checked = true;
            Listar();
        }

        private void Listar()
        {
            SQL.listarConsultaSql("spListarMedicamentosPrograma", DgvMedicamentos, true);
        }

        private void Filtrar(object sender, EventArgs e)
        {
            if (RbNombre.Checked == true)
            {
                SQL.ejeutarSpParametros("spListarMedicamentosPrograma", DgvMedicamentos, "@i_nombre", TxtValor.Text);
            }
            else
            {
                SQL.ejeutarSpParametros("spListarMedicamentosPrograma", DgvMedicamentos, "@i_concentracion", TxtValor.Text);
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmPopupMedicamentos frmPopupMedicamentos = new FrmPopupMedicamentos();
            frmPopupMedicamentos.accion = "Nuevo";
            frmPopupMedicamentos.ShowDialog();
            if (frmPopupMedicamentos.DialogResult == DialogResult.OK)
            {
                Listar();
            }
            
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            FrmPopupMedicamentos frmPopupMedicamentos = new FrmPopupMedicamentos();
            frmPopupMedicamentos.accion = "Editar";
            frmPopupMedicamentos.id = DgvMedicamentos.CurrentRow.Cells[0].Value.ToString();
            frmPopupMedicamentos.ShowDialog();
            if (frmPopupMedicamentos.DialogResult == DialogResult.OK)
            {
                Listar();
            }
        }
        
    }
}
