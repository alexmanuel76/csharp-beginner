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
    public partial class FrmConsultarMedicoPorEspecialidad : Form
    {
        public FrmConsultarMedicoPorEspecialidad()
        {
            InitializeComponent();
        }

        private void FrmConsultarMedicoPorEspecialidad_Load(object sender, EventArgs e)
        {
            DataTable datosEspecialidad = new DataTable();
            SQL.listarConsultaSql("spListarEspecialidad", datosEspecialidad, true);
            CboEspecialidad.DataSource = datosEspecialidad;
            CboEspecialidad.DisplayMember = "NOMBRE";
            CboEspecialidad.ValueMember = "ID";

            SQL.listarConsultaSql("spListarDoctor", DgvMedico,true);
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        public void Listar()
        {
            string id_especialidad = CboEspecialidad.SelectedValue.ToString();

            SQL.ejeutarSpParametros("spConsultarDoctorPorEspecialidad", DgvMedico, "@i_id_especialidad", id_especialidad);
        }

    }
}
