using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareOdontologico.Formularios
{
    public partial class MenuSoftware : Form
    {
        public MenuSoftware()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        // Evento click de la opcion de menu  Agregar / Modificar Odontologo
        private void AgregarModificarOdont(object sender, EventArgs e)
        {
            // creo una instacia de la clase AgregarOdontologo y 
            //llamo al formulario de dicha clase

            var a_m_odont = new AgregarOdontologo();
            a_m_odont.ShowDialog();

        }

        private void AgregarModificarTurnos(object sender, EventArgs e)
        {
            var a_m_turno = new Agenda();
            a_m_turno.ShowDialog();
        }

        private void ConsultarOdontologos(object sender, EventArgs e)
        {
            var cons_odont = new Odontologos();
            cons_odont.ShowDialog();
        }

        private void AgregarModificarPacientes(object sender, EventArgs e)
        {
            var a_mpacientes = new Pacientes();
            a_mpacientes.ShowDialog();
        }
    }

}
