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
        //string doc;
        Paciente paciente;
        public AgregarPaciente()
        {
            pacientesRepo = new PacientesRepo();
            odontologosRepo = new OdontologosRepo();
            InitializeComponent();
        }
        public AgregarPaciente(string documento)
        {
            pacientesRepo = new PacientesRepo();
            odontologosRepo = new OdontologosRepo();
            InitializeComponent();
            paciente = pacientesRepo.ObtenerPacienteDocumento(documento);
            rellenarFormulario();

        }
        private void rellenarFormulario()
        {
            txtDocumento.Text = paciente.nroDocumento.ToString();
            txtNombre.Text = paciente.nombre;
            txtApellido.Text = paciente.apellido;
            txtDomicilio.Text = paciente.domicilio;
            dtpFechaNacimiento.Value = paciente.fechaNacimiento;
            txtObraSocial.Text = paciente.obraSocial;
            txtPlan.Text = paciente.plan;

            var odont = odontologosRepo.ObtenerOdontMatricula(paciente.odontologo.ToString());

            var tablaOdont = odontologosRepo.ObtenerOdontologosDT();

            cmbOdontologo.SelectedValue = odont.nombre;
            for (int i = 0; i < tablaOdont.Rows.Count; i++)
            {
                foreach (DataRow f in tablaOdont.Rows)
                {

                    if (f.ItemArray[0].ToString().Equals(paciente.odontologo.ToString()))
                    {
                        cmbOdontologo.SelectedText = odont.nombre;
                    }

                }
            }



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

            //prueba cmb
            var nombre = cmbOdontologo.Text;
            paciente.odontologo = odontologosRepo.ObtenerMatriculaOdontologo(nombre);

            //Me da true ene el caso de que no exista
            if (!pacientesRepo.Validar(paciente.nroDocumento.ToString()))
            {
                if(pacientesRepo.Guardar(paciente))
                {
                    MessageBox.Show("Paciente Registrado con exito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();

                }

            }
            else
            {


                //MessageBox requiere 4 parametros.
                string mensajePrincipal = "El Paciente ya se encuentra registrado";
                string mensaje = "Desea Modificar los Datos";
                var result = MessageBox.Show(mensaje, mensajePrincipal, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //if (odontologosRepo.Actualizar(paciente, paciente.nroMatricula.ToString()))
                    { MessageBox.Show("Datos Actualizados con Exito"); }
                    this.Close();
                }

                LimpiarCampos();
            }
        }

        private void AgregarPaciente_Load(object sender, EventArgs e)
        {
            CargarCombo();
            //Verifico que la cantidada de odontologos registrados sea mayor a 1.
            //if (cmbOdontologo.Items.Count > 1)
            //{
            //    //Posiciono el combo en el valor 1, que seria la posicion 2 del combo
            //    cmbOdontologo.SelectedIndex = 1;
            //}

        }
    }
}
