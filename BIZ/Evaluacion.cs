using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIZ
{
    public class Evaluacion : Bitacora
    {
        public double Nota { get; set; }
        public string TipoNota { get; set; }
        public DateTime Fecha { get; set; }
        public int IdMateria { get; set; }
        public int LegajoAlumno { get; set; }
        public int LegajoProfesor { get; set; }

    }
}