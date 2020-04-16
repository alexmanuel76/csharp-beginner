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

namespace MiPrimeraConexionConSqlserver
{
    public partial class FrmConsultarMedicamentoPorFormaFarmaceutica : Form
    {
        public FrmConsultarMedicamentoPorFormaFarmaceutica()
        {
            InitializeComponent();
        }

        private void FrmConsultarMedicamentoPorFormaFarmaceutica_Load(object sender, EventArgs e)
        {
            DataTable tablaDeDatos = new DataTable();

            SQL.listarConsultaSql("spConsultaFormaFarmaceutica", tablaDeDatos, true);
            CboFormaFarmaceutica.DataSource = tablaDeDatos;
            CboFormaFarmaceutica.DisplayMember = "NOMBRE";
            CboFormaFarmaceutica.ValueMember = "IIDFORMAFARMACEUTICA";
        }

        private void filtrar(object sender, EventArgs e)
        {
            string valor = CboFormaFarmaceutica.SelectedValue.ToString();
            SQL.ejeutarSpParametros("spListarMedicamentoPorFormaFarmaceutica", dtgMedicamentosPorForma, "@i_id_formaFarmaceutica", valor);
        }
    }
}
