using SoftwareOdontologico.Modelos;
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
    public partial class AgregarPaciente : Form
    {
        PacientesRepo pacientesRepo;
        OdontologosRepo odontologosRepo;
        public AgregarPaciente()
        {
            pacientesRepo = new PacientesRepo();
            odontologosRepo = new OdontologosRepo();
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txtApellido.Clear();
            txtDomicilio.Clear();
            txtNombre.Clear();
            txtDocumento.Clear();
            txtObraSocial.Clear();
            txtPlan.Clear();
            dtpFechaNacimiento.ResetText();
            cmbOdontologo.ResetText();

        }
        private void CargarCombo()
        {
            var table = odontologosRepo.ObtenerOdontologosDT();
                cmbOdontologo.ValueMember = "nroMatricula";
                cmbOdontologo.DisplayMember = "Nombre";
                cmbOdontologo.DataSource = table;


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();
           
            paciente.nombre = txtNombre.Text;
            paciente.apellido = txtApellido.Text;
            paciente.domicilio = txtDomicilio.Text;
            paciente.obraSocial = txtObraSocial.Text;
            paciente.plan = txtPlan.Text;
            paciente.fechaNacimiento = dtpFechaNacimiento.Value;

            if (!paciente.ValidarNumero(txtDocumento.Text.ToString()))
            {
                MessageBox.Show("Ingrese correctamente el numero de la Documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else { paciente.nroDocumento = long.Parse(txtDocumento.Text.ToString()); }

            if (!paciente.NombreValido())
            {
                MessageBox.Show("El nombre ingresado no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!paciente.ApellidoInvalido())
            {
                MessageBox.Show("El apellido ingresado no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!paciente.DomicilioInvalido())
            {
                MessageBox.Show("El domicilio ingresado no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!paciente.FechaInvalida(dtpFechaNacimiento.Value))
            {
                 MessageBox.Show("La Fecha de Nacimiento no puede ser mayor a la fecha Actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;

            }
            if (!paciente.ObraSocialInvalida())
            {
                MessageBox.Show("La Obra Social ingresada no es valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!paciente.PlanInvalido())
            {
                MessageBox.Show("El plan ingresado no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Me da true ene el caso de que no exista
            if (!pacientesRepo.Validar(paciente.nroDocumento.ToString()))
            {
                pacientesRepo.Guardar(paciente);
                MessageBox.Show("");
            }
            else { MessageBox.Show("El paciente ya se encuentra registrado"); }
            
        }

        private void AgregarPaciente_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }
    }
}
