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
    public partial class Odontologos : Form
    {
        OdontologosRepo odontologosRepo;
        PacientesRepo pacientesRepo;
        public Odontologos()
        {
            pacientesRepo = new PacientesRepo();
            odontologosRepo = new OdontologosRepo();
            InitializeComponent();
        }

        

        private void Odontologos_Load(object sender, EventArgs e)
        {

            ActualizarGrilla();
        }
        
        public void ActualizarGrilla()
        {
            dgvOdontologos.Rows.Clear();
            var odontologos = odontologosRepo.ObtenerOdontologosDT().Rows;
            // Recorre cada fila de la tabla Odontologos
            foreach (DataRow odont in odontologos)
            {
                //no corto el ciclo
                if (odont.HasErrors)
                    continue;
                //Creo una arreglo fila con los datos de las columnas de la tabla 
                var fila = new string[]
                {
                    // cargo el arreglo con los datos de la primera fila de la tabla
                    odont.ItemArray[0].ToString(),
                    odont.ItemArray[1].ToString(),
                    odont.ItemArray[2].ToString(),
                    odont.ItemArray[3].ToString(),
                    odont.ItemArray[4].ToString(),
                    odont.ItemArray[5].ToString(),
                };
                //Cargo en la DataGridView cada fila con el arreglo fila en cada vuelta, 
                // hasta que corte el ciclo
                dgvOdontologos.Rows.Add(fila);

            }
        }
        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Eliminar Fila
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var filas = dgvOdontologos.SelectedRows;
            if (filas.Count  == 0 || filas.Count > 1)
            {
                
                MessageBox.Show("Debe Seleccionar una fila","Sistema",MessageBoxButtons.OK,MessageBoxIcon.Exclamation) ;
                return;
            }

            foreach ( DataGridViewRow f in filas)
            {

                var matricula = f.Cells[0].Value.ToString();
                var nombreApellido = f.Cells[2].Value.ToString() +" "+ f.Cells[3].Value.ToString();
                var elec = MessageBox.Show("Esta seguro que desea eliminar los datos", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if(elec == DialogResult.Yes) {
                    var tablaPacientesOdont = pacientesRepo.ObtenerPacientesDTmat(matricula);
                    if (tablaPacientesOdont.Rows.Count>0)
                    {
                        MessageBox.Show($"El Odontologo {nombreApellido} tiene Pacientes registrados", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        
                    }
                    else { odontologosRepo.Eliminar(matricula); }
                    
                }
                
                
            }
            
            ActualizarGrilla();
        }
        //Modificar Fila
        private void btnModificar_Click(object sender, EventArgs e)
        {
            var filasSelec = dgvOdontologos.SelectedRows;
            // valido que las filas seleccionadas sea 1
            if (filasSelec.Count == 0 || filasSelec.Count > 1)
            {
                MessageBox.Show("Debe Seleccionar una fila", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            
            //recorro la fila seleccionada y me quedo con la matricula 
            foreach (DataGridViewRow fila in filasSelec)
            {
                // creo una variable nroMatricula donde almacenare la matricula de la fila seleccionada en la dgv
                var nroMatricula = fila.Cells[0].Value;
                var elec = MessageBox.Show("Esta seguro que desea modificar los datos","Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if(elec == DialogResult.No)
                {
                    return;
                }
                //llamo al formulario para editar odontologo y le paso por parametro la matricula como string 
                var mod_odont = new AgregarOdontologo(nroMatricula.ToString());
      
                mod_odont.ShowDialog();
                ActualizarGrilla();
            }
        }
    }
}
