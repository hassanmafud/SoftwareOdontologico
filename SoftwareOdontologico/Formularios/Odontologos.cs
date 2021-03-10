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
        public Odontologos()
        {
            odontologosRepo = new OdontologosRepo();
            InitializeComponent();
        }

        

        private void Odontologos_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        public void ActualizarGrilla()
        {
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
