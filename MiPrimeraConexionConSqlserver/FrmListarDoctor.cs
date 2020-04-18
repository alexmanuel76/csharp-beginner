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
    public partial class FrmListarDoctor : Form
    {
        public FrmListarDoctor()
        {
            InitializeComponent();
        }

        private void FrmListarDoctor_Load(object sender, EventArgs e)
        {
            RbPaterno.Checked = true;
            ListadorGeneral();
        }

        /**
         * 
         * Rutina para llegar el DataGrid General
         * */
        private void ListadorGeneral()
        {
            SQL.listarConsultaSql("spListarDoctorPrograma", DgvDoctor, true);
        }

        private void Listar(object sender, EventArgs e)
        {
            if (RbPaterno.Checked == true)
            {
                SQL.ejeutarSpParametros("spListarDoctorPrograma", DgvDoctor, "@i_paterno", TxtApellido.Text);
            }
            else
            {
                SQL.ejeutarSpParametros("spListarDoctorPrograma", DgvDoctor, "@i_materno", TxtApellido.Text);
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmPopupDoctor frmPopupDoctor = new FrmPopupDoctor();
            frmPopupDoctor.accion = "Nuevo";
            frmPopupDoctor.ShowDialog();
            if (frmPopupDoctor.DialogResult.Equals(DialogResult.OK))
            {
                ListadorGeneral();
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            FrmPopupDoctor frmPopupDoctor = new FrmPopupDoctor();
            frmPopupDoctor.accion = "Editar";
            frmPopupDoctor.id = DgvDoctor.CurrentRow.Cells[5].Value.ToString();
            frmPopupDoctor.ShowDialog();
            if (frmPopupDoctor.DialogResult.Equals(DialogResult.OK))
            {
                ListadorGeneral();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Eliminar el Doctor??", "Mantenimiento de Doctor",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                 .Equals(DialogResult.Yes))
            {
                string idDoctor = DgvDoctor.CurrentRow.Cells[5].Value.ToString();
                int resultado = SQL.EjeutarSp("spEliminarDoctor",
                                               new System.Collections.ArrayList { "@i_id_doctor" },
                                               new System.Collections.ArrayList { idDoctor });
                if (resultado.Equals(1))
                {
                    MessageBox.Show("Doctor Eliminado con exito", "Mantenimiento de Doctor",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListadorGeneral();
                }
                else
                {
                    MessageBox.Show("Error al eliminar Doctor", "Mantenimiento de Doctor",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
