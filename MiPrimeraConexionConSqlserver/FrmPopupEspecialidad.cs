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
    public partial class FrmPopupEspecialidad : Form
    {
        public string accion{ get; set; }
        public string idEspecialidad { get; set; }

        public FrmPopupEspecialidad()
        {
            InitializeComponent();
        }

        private void FrmPopupEspecialidad_Load(object sender, EventArgs e)
        {
            if (accion.Equals("Nuevo"))
            {
                this.Text = "Agregar Especialidad";
            }else if (accion.Equals("Editar"))
            {
                this.Text = "Editar Especialidad";
                DataTable tablaDeDatos = SQL.ejecutarSPConsulta("spConsultarEspecialidad", "@i_id_especialidad", idEspecialidad);
                TxtIdEspecialidad.Text = tablaDeDatos.Rows[0][0].ToString();
                TxtEspecialidad.Text = tablaDeDatos.Rows[0][1].ToString();
                TxtDescripcion.Text = tablaDeDatos.Rows[0][2].ToString();
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            string mensajeOk = "";
            string mensajeNoOk = "";

            string nombreEspecialidad = TxtEspecialidad.Text.ToUpper();
            string descripcion = TxtDescripcion.Text.ToUpper();
            if (accion.Equals("Nuevo"))
            {
                MessageBox.Show("Agregar");
            }else if (accion.Equals("Editar"))
            {
                resultado = SQL.EjeutarSp("spModificarEspecialidad",
                                          new ArrayList { "@i_id_especialidad", "@i_nombre"       , "@i_descripcion" },
                                          new ArrayList { idEspecialidad , nombreEspecialidad, descripcion});

                mensajeOk = "Especialidad Modificada Exitosamente";
                mensajeNoOk = "Problemas para Modificar la Especialidad";
            }

            if (resultado == 1)
            {
                MessageBox.Show(mensajeOk, "Mantenimiento de Especialidad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(mensajeNoOk, "Mantenimiento de Especialidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
            }
        
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
