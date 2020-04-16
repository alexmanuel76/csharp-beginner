using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace MiPrimeraConexionConSqlserver
{
    public partial class FrmListadoEspecialidad : Form
    {
        public FrmListadoEspecialidad()
        {
            InitializeComponent();
        }

        private void FrmListadoEspecialidad_Load(object sender, EventArgs e)
        {
            SQL.listarConsultaSql("sp_listarEspecialidades", dtgEspecialidad,true);


           // dtgEspecialidad.DataSource = tabla;
        }

        private void filtrarEspecialidad(object sender, EventArgs e)
        {
            Object[] parametrosSQL = new Object[2];
            parametrosSQL[0] = "@i_nombre_especialidad";
            parametrosSQL[1] = TxtNombreEspecialidad.Text;

            HashSet<Object> parametros = new HashSet<object>();
            parametros.Add(parametrosSQL);
            SQL.ejeutarSpParametros("spListarEspecialidadPorNombre", dtgEspecialidad, parametros);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            FrmPopupEspecialidad frmPopupEspecialidad = new FrmPopupEspecialidad();
            frmPopupEspecialidad.accion = "Editar";
            frmPopupEspecialidad.idEspecialidad = dtgEspecialidad.CurrentRow.Cells[0].Value.ToString();
            frmPopupEspecialidad.ShowDialog();
            if (frmPopupEspecialidad.DialogResult.Equals(DialogResult.OK))
            {
                SQL.listarConsultaSql("sp_listarEspecialidades", dtgEspecialidad, true);
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmPopupEspecialidad frmPopupEspecialidad = new FrmPopupEspecialidad();
            frmPopupEspecialidad.accion = "Nuevo";
            frmPopupEspecialidad.ShowDialog();
            if (frmPopupEspecialidad.DialogResult.Equals(DialogResult.OK))
            {
                SQL.listarConsultaSql("sp_listarEspecialidades", dtgEspecialidad, true);
            }
        }
    }
}
