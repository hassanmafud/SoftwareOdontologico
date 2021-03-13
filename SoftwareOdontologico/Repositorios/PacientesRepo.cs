﻿using SoftwareOdontologico.Base_de_Datos;
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

            string sqltxt = $" INSERT Pacientes ([nroDocumento],[nombre],[apellido],[domicilio],[fechaNacimiento], [obraSocial], [plan])" +
                $" VALUES('{paciente.nroDocumento}','{paciente.nombre}','{paciente.apellido}','{paciente.domicilio}'," +
                $"'{paciente.fechaNacimiento.ToString("yyyy-MM-dd")}','{paciente.obraSocial}','{paciente.plan}')";

            return _BD.EjecutarSQL(sqltxt);
        }

        public bool Validar(string dni)
        {
            string sqltxt = $"SELECT * FROM Pacientes WHERE nroDocumento = {dni}";
            DataTable tabla = _BD.consulta(sqltxt);
            if (tabla.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
