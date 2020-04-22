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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void clinicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClinicas frmClinicas = new FrmClinicas();
            frmClinicas.MdiParent = this;
            frmClinicas.Show();
        }

        private void especialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListadoEspecialidad frmListadoEspecialidad = new FrmListadoEspecialidad();
            frmListadoEspecialidad.MdiParent = this;
            frmListadoEspecialidad.Show();
        }

        private void medicamentoPorFormaFarmaceuticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarMedicamentoPorFormaFarmaceutica formaFarmaceutica = new FrmConsultarMedicamentoPorFormaFarmaceutica();
            formaFarmaceutica.MdiParent = this;
            formaFarmaceutica.Show();
        }

        private void medicoPorEspecialistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarMedicoPorEspecialidad medicoPorEspecialidad = new FrmConsultarMedicoPorEspecialidad();
            medicoPorEspecialidad.MdiParent = this;
            medicoPorEspecialidad.Show();
        }

        private void medicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarDoctor listarDoctor = new FrmListarDoctor();
            listarDoctor.MdiParent = this;
            listarDoctor.Show();
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListadoPaciente listadoPaciente = new FrmListadoPaciente();
            listadoPaciente.MdiParent = this;
            listadoPaciente.Show();
        }

        private void medicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListadoMedicamentos listadoMedicamentos = new FrmListadoMedicamentos();
            listadoMedicamentos.MdiParent = this;
            listadoMedicamentos.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListadoUsuarios listadoUsuarios = new FrmListadoUsuarios();
            listadoUsuarios.MdiParent = this;
            listadoUsuarios.Show();
        }
    }
}
