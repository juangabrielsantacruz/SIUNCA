using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIZ
{
    public class AlumnoMateria : Bitacora
    {
        public int IdAlumno { get; set; }
        public int LegajoAlumno { get; set; }
        public int IdMateria { get; set; }
        public string Estado { get; set; }
        public Materias Materias { get; set; }

    }
}