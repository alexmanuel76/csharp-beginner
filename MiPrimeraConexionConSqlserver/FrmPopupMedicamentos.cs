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
    public partial class FrmPopupMedicamentos : Form
    {
        public string accion { get; set; }
        public string id { get; set; }

        public FrmPopupMedicamentos()
        {
            InitializeComponent();
        }

        private void FrmPopupMedicamentos_Load(object sender, EventArgs e)
        {
            DataTable datos = new DataTable();
            SQL.listarConsultaSql("spConsultaFormaFarmaceutica", datos, true);
            CboFormaFarmaceutica.DataSource = datos;
            CboFormaFarmaceutica.DisplayMember = "NOMBRE";
            CboFormaFarmaceutica.ValueMember = "IIDFORMAFARMACEUTICA";
            if (accion.Equals("Nuevo"))
            {
                this.Text = "Crear Medicamento";
            }
            else
            {
                this.Text = "Modificar Medicamento";
                DataTable tablaDeDatos = SQL.ejecutarSPConsulta("spConsultarMedicamento", "@i_id_medicamento", id);
                TxtIdMedicamento.Text = tablaDeDatos.Rows[0][0].ToString();
                TxtNombre.Text = tablaDeDatos.Rows[0][1].ToString();
                TxtConcentracion.Text = tablaDeDatos.Rows[0][2].ToString();
                CboFormaFarmaceutica.SelectedValue = tablaDeDatos.Rows[0][3].ToString();
                NumPrecio.Value = decimal.Parse(tablaDeDatos.Rows[0][4].ToString());
                NumStock.Value = decimal.Parse(tablaDeDatos.Rows[0][5].ToString());
                TxtPresentacion.Text = tablaDeDatos.Rows[0][6].ToString();
            }
                
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            string nombre = TxtNombre.Text.ToUpper();
            string conentracion = TxtConcentracion.Text.ToUpper();
            string idFormaFarmaceutica = CboFormaFarmaceutica.SelectedValue.ToString();
            decimal precio = NumPrecio.Value;
            int stock = int.Parse(NumStock.Value.ToString());
            string presentacion = TxtPresentacion.Text;

            bool validos = SQL.validarRequeridos(this.Controls,ErrControl);

            if (!validos)
            {
                this.DialogResult = DialogResult.None;
                return;
            }

            if (accion.Equals("Nuevo"))
            {
                resultado = SQL.EjeutarSp("spInsertarMedicamentos",
                                      new ArrayList { "@i_nombre", "@i_concentracion", "@i_id_forma_farmaceutica",
                                                      "@i_precio", "@i_stock"        , "@i_presentacion" },
                                      new ArrayList { nombre     , conentracion      , idFormaFarmaceutica,
                                                      precio     , stock             , presentacion});
                if (resultado == 1)
                {
                    MessageBox.Show("Medicamento Agregado Exitosamente", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Problemas para agregar Medicamento o ya Existe", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.None;
                }
            }
        }
    }
}
