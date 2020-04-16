using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace MiPrimeraConexionConSqlserver
{
    public partial class FrmPopupClinica : Form
    {
        public string accion { get; set; }
        public string id { get; set; }

        public FrmPopupClinica()
        {
            InitializeComponent();
        }

        private void FrmPopupClinica_Load(object sender, EventArgs e)
        {
            if (accion.Equals("Nuevo"))
            {
                this.Text = "Agregar Clinica";
            }
            else if(accion.Equals("Editar"))
            {
                this.Text = "Editar Clinica";
                DataTable dataTable = SQL.ejecutarSPConsulta("spConsultarClinica", "@i_id_clinica", id);
                TxtIdClinica.Text = id;
                TxtNombre.Text = dataTable.Rows[0][1].ToString();
                TxtDireccion.Text = dataTable.Rows[0][2].ToString();
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            string mensajeOk = "";
            string mensajeNoOk = "";

            string nombre = TxtNombre.Text.ToUpper();
            string direccion = TxtDireccion.Text.ToUpper();
            bool validacionExitosa = SQL.validarRequeridos(this.Controls, ErrorDatos);

            if (!validacionExitosa)
            {
                this.DialogResult = DialogResult.None;
                return;
            }
            
            if (accion.Equals("Nuevo"))
            {
                resultado = SQL.EjeutarSp("spCrearClinica",
                                           new ArrayList { "@i_nombre", "@i_direccion" },
                                           new ArrayList { nombre, direccion });

                mensajeOk = "Clinica Agregada Exitosamente";
                mensajeNoOk = "Problemas para agregar la clinica o ya Existe";
            }else if (accion.Equals("Editar"))
            {
                resultado = SQL.EjeutarSp("spModificarClinica",
                                           new ArrayList { "@i_id_clinica", "@i_nombre", "@i_direccion" },
                                           new ArrayList {  id, nombre, direccion });

                mensajeOk = "Clinica Modificada Exitosamente";
                mensajeNoOk = "Problemas para Modificar la clinica";
            }
            
            if (resultado == 1)
            {
                MessageBox.Show(mensajeOk, "Mantenimiento de Clinica",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(mensajeNoOk, "Mantenimiento de Clinica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
            }
        }
    }
}
