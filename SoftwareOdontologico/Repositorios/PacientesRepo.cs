using SoftwareOdontologico.Base_de_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOdontologico.Repositorios
{
    public class PacientesRepo
    {
        private Consultorio_BD _BD;

        public PacientesRepo()
        {
            _BD = new Consultorio_BD();
        }

        public bool Guardar()
        {

            string sqltxt = "INSERT INTO dbo.Pacientes(nroPaciente, nroDocumento, nombre, apellido, domicilio, fechaNacimiento) VALUES()";

            return _BD.EjecutarSQL(sqltxt);
        }


    }
}
