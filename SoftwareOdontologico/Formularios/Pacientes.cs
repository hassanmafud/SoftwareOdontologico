using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftwareOdontologico.Repositorios;

namespace SoftwareOdontologico.Formularios
{
    public partial class Pacientes : Form
    {
        OdontologosRepo odontologosRepo;
        public Pacientes()
        {
            odontologosRepo = new OdontologosRepo();
            InitializeComponent();
        }

        private void cargarCombo()
        {
            var tableOdontologos = odontologosRepo.ObtenerOdontologosDT();
            cmbOdontologo.ValueMember = "nroMatricula";
            cmbOdontologo.DisplayMember = "nombre";
            cmbOdontologo.DataSource = tableOdontologos;
        }

        private void Pacientes_Load(object sender, EventArgs e)
        {
            cargarCombo();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
