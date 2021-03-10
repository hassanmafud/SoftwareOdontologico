using SoftwareOdontologico.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareOdontologico
{
    public partial class Agenda : Form
    {
        //declaracion del Repo
        OdontologosRepo odontologosRepo;
        //Constructor
        public Agenda()
        {
            odontologosRepo = new OdontologosRepo();
            InitializeComponent();
        }

        
        private void Agenda_Load(object sender, EventArgs e)
        {
            CargarComboOdontologos();
        }

        private void CargarComboOdontologos()
        {
            var tablaOdontologos = odontologosRepo.ObtenerOdontologosDT();
            cmbOdontologos.ValueMember = "nroMatricula";
            cmbOdontologos.DisplayMember = "nombre";
            cmbOdontologos.DataSource = tablaOdontologos;

        }
    }
}
