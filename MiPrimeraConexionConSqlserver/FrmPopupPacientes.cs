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
using System.IO;

namespace MiPrimeraConexionConSqlserver
{
    public partial class FrmPopupPacientes : Form
    {
        public string accion { get; set; }
        public string idPaciente { get; set; }
        byte[] foto = null;

        public FrmPopupPacientes()
        {
            InitializeComponent();
        }

        private void FrmPopupPacientes_Load(object sender, EventArgs e)
        {
            SQL.listarConsultaSql("spListarSexo", CboSexo, true, "ID", "SEXO");
            SQL.listarConsultaSql("spListarTipoSangre", CboTipoSangre, true, "ID", "TIPO");

            if (accion.Equals("Nuevo"))
            {
                this.Text = "Crear Paciente";
            }
            else if (accion.Equals("Editar"))
            {
                this.Text = "Modificar/Eliminar Paciente";
                DataTable tablaDeDatos = SQL.ejecutarSPConsulta("spConsultarPaciente", "@i_id_paciente", idPaciente);
                TxtIdPaciente.Text = tablaDeDatos.Rows[0][0].ToString();
                TxtNombre.Text = tablaDeDatos.Rows[0][1].ToString();
                TxtApellidoPaterno.Text = tablaDeDatos.Rows[0][2].ToString();
                TxtApellidoMaterno.Text = tablaDeDatos.Rows[0][3].ToString();
                TxtEmail.Text = tablaDeDatos.Rows[0][4].ToString();
                TxtDireccion.Text = tablaDeDatos.Rows[0][5].ToString();
                TxtTelefono.Text = tablaDeDatos.Rows[0][6].ToString();
                TxtCelular.Text = tablaDeDatos.Rows[0][7].ToString();
                DtFechaNacimiento.Value = DateTime.Parse( tablaDeDatos.Rows[0][8].ToString());
                CboSexo.SelectedValue = tablaDeDatos.Rows[0][9].ToString();
                CboTipoSangre.SelectedValue =  tablaDeDatos.Rows[0][10].ToString();
                TxtAlergias.Text = tablaDeDatos.Rows[0][11].ToString();
                TxtEnfermedades.Text = tablaDeDatos.Rows[0][12].ToString();
                TxtVacunas.Text = tablaDeDatos.Rows[0][13].ToString();
                TxtAntecedentes.Text = tablaDeDatos.Rows[0][14].ToString();
                foto = (byte[])tablaDeDatos.Rows[0][15];
                using (MemoryStream memoryStream = new MemoryStream(foto))
                {
                    PbFfoto.Image = Image.FromStream(memoryStream);
                }
            }           
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            string mensajeOk = "";
            string mensajeNoOk = "";
            bool validaciones = SQL.validarRequeridos(this.Controls, ControlErrores);
            int resultado = 0;
            string nombre = TxtNombre.Text.ToUpper();
            string apellidoPaterno = TxtApellidoPaterno.Text.ToUpper();
            string apellidoMaterno = TxtApellidoMaterno.Text.ToUpper();
            string email = TxtEmail.Text;
            string direccion = TxtDireccion.Text.ToUpper();
            string telefonoFijo = TxtTelefono.Text;
            string telefonoCelular = TxtCelular.Text;
            DateTime fechaNacimiento = DtFechaNacimiento.Value;
            string idSexo = CboSexo.SelectedValue.ToString();
            string idTipoSangre = CboTipoSangre.SelectedValue.ToString();
            string alergias = TxtAlergias.Text;
            string enfermedades = TxtEnfermedades.Text;
            string cuadroVacunas = TxtVacunas.Text;
            string antecedentes = TxtAntecedentes.Text;
            

            if (!validaciones)
            {
                this.DialogResult = DialogResult.None;
                return;
            }

            //EJECUCION DEL SP
            if (accion.Equals("Nuevo"))
            {
                resultado = SQL.EjeutarSp("spPaciente", new ArrayList {"@i_nombre"          , "@i_apaterno"                , "@i_amaterno"     ,
                                                                   "@i_email"           , "@i_direccion"               , "@i_telefono_fijo",
                                                                   "@i_telefono_celular", "@i_fecha_nacimiento"        , "@i_id_sexo"      ,
                                                                   "@i_id_tipo_sangre"  , "@i_alergias"                , "@i_enfermedades" ,
                                                                   "@i_cuadro_vacunas"  , "@i_antecedentes_quirurgicos", "@i_foto" },
                                                        new ArrayList { nombre              , apellidoPaterno              , apellidoMaterno   ,
                                                                    email               , direccion                    , telefonoFijo      ,
                                                                    telefonoCelular     , fechaNacimiento              , idSexo            ,
                                                                    idTipoSangre        , alergias                     , enfermedades      ,
                                                                    cuadroVacunas       ,antecedentes                  ,foto});
                mensajeOk = "Paciente Agregado Exitosamente";
                mensajeNoOk = "Problemas para agregar Paciente o ya Existe";
            }
            else if (accion.Equals("Editar"))
            {
                mensajeOk = "Paciente modificado exitosamente";
                mensajeNoOk = "No se pudo modificar el paciente";
            }
            
            if (resultado == 1)
            {
                MessageBox.Show(mensajeOk, "Mantenimiento de Pacientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(mensajeNoOk, "Mantenimiento de Pacientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
            }

        }

        private void BtnFoto_Click(object sender, EventArgs e)
        {
            string ruta = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivo de Programa |*.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog().Equals(DialogResult.OK))
            {
                ruta = openFileDialog.FileName;
                foto = File.ReadAllBytes(ruta);
                using(MemoryStream memorystream = new MemoryStream(foto))
                {
                    PbFfoto.Image = Image.FromStream(memorystream);
                }
            }
        }
    }
}
