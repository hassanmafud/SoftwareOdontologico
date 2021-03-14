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
        PacientesRepo pacientesRepo;
        public Pacientes()
        {
            pacientesRepo = new PacientesRepo();
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
            ActualizarGrilla(0);
            cargarCombo();
        }

        private void ActualizarGrilla(long matricula)
        {   //limpia la grilla
            dgvPacientes.Rows.Clear();
            DataTable tablaPacientes;
            //Recupero un datatable con los pacientes
            if (matricula != 0)
            {
                tablaPacientes = pacientesRepo.ObtenerPacientesDTmat(matricula.ToString());
            }
            else {
                tablaPacientes = pacientesRepo.ObtenerPacientesDT();
            }
             

            //Recorro la tabla fila por fila
            foreach (DataRow filaTabla in tablaPacientes.Rows)
            {
                if(filaTabla.HasErrors)
                    continue;
                //Creo un arreglo de strings en el cual guardo los datos de cada fila 
                var filaGrilla = new string[]
                {
                   filaTabla.ItemArray[0].ToString(),
                   filaTabla.ItemArray[1].ToString(),
                   filaTabla.ItemArray[2].ToString(),
                   filaTabla.ItemArray[3].ToString(),
                   filaTabla.ItemArray[4].ToString(),
                   filaTabla.ItemArray[5].ToString(),
                   filaTabla.ItemArray[6].ToString(),
                   filaTabla.ItemArray[7].ToString(),

                };
                //Agrego en la DGV en cada fila el arreglo que contiene los datos de cada fila de la tabla
                dgvPacientes.Rows.Add(filaGrilla);
                   
                
                
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var nombreOdontCmb = cmbOdontologo.Text;
            var matriculaOdontCmb = odontologosRepo.ObtenerMatriculaOdontologo(nombreOdontCmb);
            ActualizarGrilla(matriculaOdontCmb);

        }
    }
}
