using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace MiPrimeraConexionConSqlserver
{
    public partial class FrmPopupDoctor : Form
    {
        public string accion { get; set; }
        public string id { get; set; }
        private string archivo = null;
        private string nombreArchivo = null;
        private byte[] bufferArchivo = null;

        private void FrmPopupDoctor_Load(object sender, EventArgs e)
        {
            SQL.listarConsultaSql("spListarSexo", CboSexo, true, "ID", "SEXO");
            SQL.listarConsultaSql("spListarEspecialidad", CboEspecialidad, true, "ID", "NOMBRE");
            SQL.listarConsultaSql("spListarClinicas", CboClinica, true, "ID", "NOMBRE");
            if (accion.Equals("Nuevo"))
            {
                this.Text = "Agregar Medico";
            }
            else if (accion.Equals("Editar"))
            {
                this.Text = "Editar Medico";
                DataTable tablaDeDatos = SQL.ejecutarSPConsulta("spBuscarDoctor", "@i_id_doctor", this.id);
                TxtIdDoctor.Text = tablaDeDatos.Rows[0][0].ToString();
                TxtNombre.Text = tablaDeDatos.Rows[0][1].ToString();
                TxtApePaterno.Text = tablaDeDatos.Rows[0][2].ToString();
                TxtApeMaterno.Text = tablaDeDatos.Rows[0][3].ToString();
                CboClinica.SelectedValue = tablaDeDatos.Rows[0][4].ToString();
                CboEspecialidad.SelectedValue = tablaDeDatos.Rows[0][5].ToString();
                TxtEmail.Text = tablaDeDatos.Rows[0][6].ToString();
                TxtTelefono.Text = tablaDeDatos.Rows[0][7].ToString();
                CboSexo.SelectedValue = tablaDeDatos.Rows[0][8].ToString();
                NumSueldo.Value = decimal.Parse(tablaDeDatos.Rows[0][9].ToString());
                DtFechaContrato.Value = DateTime.Parse(tablaDeDatos.Rows[0][10].ToString());
                bufferArchivo = (byte[])tablaDeDatos.Rows[0][11];
                nombreArchivo = tablaDeDatos.Rows[0][12].ToString();
                if(nombreArchivo.ToString() != "")
                {
                    string rutaTemporal = Path.Combine(Path.GetTempPath(),nombreArchivo);
                    File.WriteAllBytes(rutaTemporal, bufferArchivo);
                    WbArchivo.Navigate(rutaTemporal);

                }
            }
            
        }

        public FrmPopupDoctor()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            string mensajeOk = "";
            string mensajeNoOk = "";
            int resultado = 0;
            bool validado = SQL.validarRequeridos(this.Controls, ControlDeError);
            if (!validado)
            {
                this.DialogResult = DialogResult.None;
                return;
            }
            
            
            if (bufferArchivo == null)
            {
                ControlDeError.SetError(WbArchivo, "Por favor seleccionar Archivo");
                return;
            }
            
            string nombre = TxtNombre.Text.ToUpper();
            string apellidoPaterno = TxtApePaterno.Text.ToUpper();
            string apellidoMaterno = TxtApeMaterno.Text.ToUpper();
            string idClinica = CboClinica.SelectedIndex.ToString();
            string especialidad = CboEspecialidad.SelectedValue.ToString();
            string email = TxtEmail.Text.ToUpper();
            string telefono = TxtTelefono.Text;
            string idSexo = CboSexo.SelectedValue.ToString();
            decimal sueldo = NumSueldo.Value;
            DateTime fechaContrato = DtFechaContrato.Value;

            if (accion.Equals("Nuevo"))
            {
                resultado = SQL.EjeutarSp("spCrearDoctor", new ArrayList { "@i_nombre"        , "@i_apellido_paterno", "@i_apellido_materno",
                                                                           "@i_id_clinica"    , "@i_id_especialidad" , "@i_email"           ,
                                                                           "@i_telefono"      , "@i_id_sexo"         , "@i_sueldo"          ,
                                                                           "@i_fecha_contrato", "@i_archivo"         , "@i_nombre_archivo"},
                                                           new ArrayList {  nombre            , apellidoPaterno      , apellidoMaterno,
                                                                            idClinica         , especialidad         , email,
                                                                            telefono          , idSexo               , sueldo,
                                                                            fechaContrato     , bufferArchivo        , nombreArchivo});
                mensajeOk = "Doctor Agregado Exitosamente";
                mensajeNoOk = "Problemas para agregar Doctor o ya Existe";
            }else if (accion.Equals("Editar"))
            {
                mensajeOk = "Doctor Modificado con Exito";
                mensajeNoOk = "Problemas para modificar el doctor";
            }
            
            if (resultado.Equals(1))
            {
                MessageBox.Show(mensajeOk, "Mantenimiento de Doctor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(mensajeNoOk, "Mantenimiento de Doctor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;

            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        

        private void BtnArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Archivo de programa |*.jpg;*.jpeg;*.png;*.pdf;*.docx";
            if (openFile.ShowDialog().Equals(DialogResult.OK))
            {
                archivo = openFile.FileName;
                nombreArchivo = openFile.SafeFileName;
                bufferArchivo = File.ReadAllBytes(archivo);
                WbArchivo.Navigate(archivo);
            }
        }
    }
}
