using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.D_2015.Persistencia;

namespace BIZ
{
    public class Alumno : Bitacora
    {
        public int LegajoAlumno { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Sexo { get; set; }
        public string Email { get; set; }
        public int IdCarrera { get; set; }
        public List<Asistencia> Asistencia { get; set; }
        public List<Evaluacion> Evaluacion { get; set; }
        public Promedio Promedio { get; set; }
        public List<AlumnoMateria> AlumnoMateria { get; set; }

    }
}