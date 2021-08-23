using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ.DTOs
{
    public class DTOAlumno
    {
        public int LegajoAlumno { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Ausente { get; set; }
        public string Presente { get; set; }
        public string Estado { get; set; }
        public int IdMateriaCC { get; set; }
    }
}
