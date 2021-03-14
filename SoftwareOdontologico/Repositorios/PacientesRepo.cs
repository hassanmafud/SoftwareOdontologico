using SoftwareOdontologico.Base_de_Datos;
using SoftwareOdontologico.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOdontologico.Repositorios
{
    class PacientesRepo
    {
        private Consultorio_BD _BD;

        public PacientesRepo()
        {
            _BD = new Consultorio_BD();
        }

        public bool Guardar(Paciente paciente)
        {

            string sqltxt = $" INSERT Pacientes ([nroDocumento],[nombre],[apellido],[domicilio],[fechaNacimiento], [obraSocial], [plan],[odontologo])" +
                $" VALUES('{paciente.nroDocumento}','{paciente.nombre}','{paciente.apellido}','{paciente.domicilio}'," +
                $"'{paciente.fechaNacimiento.ToString("yyyy-MM-dd")}','{paciente.obraSocial}','{paciente.plan}',{paciente.odontologo})";

            return _BD.EjecutarSQL(sqltxt);
        }

        public bool Validar(string dni)
        {
            string sqltxt = $"SELECT * FROM Pacientes WHERE nroDocumento = {dni}" ;
            DataTable tabla = _BD.consulta(sqltxt);
            if (tabla.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public bool Eliminar(string documento)
        {
            string sqltxt = $"DELETE FROM Pacientes WHERE nroDocumento = {documento}";
            return _BD.EjecutarSQL(sqltxt);
        }
        public DataTable ObtenerPacientesDTmat(string matricula)
        {
            string sqltxt = $"SELECT * FROM Pacientes WHERE odontologo = {matricula}";
            var tablaPacientes = _BD.consulta(sqltxt);
            return tablaPacientes;
        }
        public DataTable ObtenerPacientesDT()
        {
            string sqltxt = $"SELECT * FROM Pacientes ";
            var tablaPacientes = _BD.consulta(sqltxt);
            return tablaPacientes;
        }

        public Paciente ObtenerPacienteDocumento(string documento)
        {
            string sqltxt = $"SELECT * FROM Pacientes WHERE nroDocumento = {documento}";
            var tablaPaciente = _BD.consulta(sqltxt);

            Paciente paciente = new Paciente();
            foreach (DataRow f in tablaPaciente.Rows)
            {
                paciente.nroDocumento = long.Parse(f.ItemArray[0].ToString());
                paciente.nombre = f.ItemArray[1].ToString();
                paciente.apellido = f.ItemArray[2].ToString();
                paciente.domicilio = f.ItemArray[3].ToString();
                paciente.fechaNacimiento = DateTime.Parse(f.ItemArray[4].ToString());
                paciente.obraSocial = f.ItemArray[5].ToString();
                paciente.plan = f.ItemArray[6].ToString();
                paciente.odontologo = long.Parse(f.ItemArray[7].ToString());

            }
            return paciente;

        }
        public bool Actualizar(Paciente paciente, string documento)
        {
            string sqltxt = $"UPDATE Pacientes SET nombre= '{paciente.nombre}', apellido= '{paciente.apellido}'" +
                $", domicilio = '{paciente.domicilio}', fechaNacimiento = '{paciente.fechaNacimiento.ToString("yyyy-MM-dd")}'" +
                $", obraSocial = '{paciente.obraSocial}', plan = '{paciente.plan}', odontologo='{paciente.odontologo}' WHERE documento = {documento}";

            return _BD.EjecutarSQL(sqltxt);

        }
    }
}
