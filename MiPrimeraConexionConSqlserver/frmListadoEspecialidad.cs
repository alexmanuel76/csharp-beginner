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
            ListarEspecialidades();
        }

        private void ListarEspecialidades()
        {
            SQL.listarConsultaSql("sp_listarEspecialidades", dtgEspecialidad, true);
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
            if(MessageBox.Show("Desea Eliminar la especialidad?", 
                               "Mantenimiento de Especialidad", 
                               MessageBoxButtons.YesNo, 
                               MessageBoxIcon.Question)
                               .Equals(DialogResult.Yes))
            {
                int resultado = SQL.EjeutarSp("spEliminarEspecialidad",
                                              new System.Collections.ArrayList { "@i_id_especialidad" },
                                              new System.Collections.ArrayList { dtgEspecialidad.CurrentRow.Cells[0].Value.ToString() });
                
                if (resultado.Equals(1))
                {
                    MessageBox.Show("Especialidad eliminada con exito",
                                    "Mantenimiento de Especialidad",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    ListarEspecialidades();
                }
                else
                {
                    MessageBox.Show("Problemas para eliminar Especialidad",
                                    "Mantenimiento de Especialidad",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            FrmPopupEspecialidad frmPopupEspecialidad = new FrmPopupEspecialidad();
            frmPopupEspecialidad.accion = "Editar";
            frmPopupEspecialidad.idEspecialidad = dtgEspecialidad.CurrentRow.Cells[0].Value.ToString();
            frmPopupEspecialidad.ShowDialog();
            if (frmPopupEspecialidad.DialogResult.Equals(DialogResult.OK))
            {
                ListarEspecialidades();
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmPopupEspecialidad frmPopupEspecialidad = new FrmPopupEspecialidad();
            frmPopupEspecialidad.accion = "Nuevo";
            frmPopupEspecialidad.ShowDialog();
            if (frmPopupEspecialidad.DialogResult.Equals(DialogResult.OK))
            {
                ListarEspecialidades();
            }
        }
    }
}
