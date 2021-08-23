using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIZ
{
    public class Asistencia : Bitacora
    {
        public int IdAsistencia { get; set; }
        public string Ausente { get; set; }
        public string Presente { get; set; }
        public DateTime Fecha { get; set; }
        public int IdMateriaCC { get; set; }
        public int LegajoAlumno { get; set; }
        //public int Estado { get; set; }
    }
}