using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIZ
{
    public class Profesor : Bitacora
    {
        public int Apellido { get; set; }
        public int DNI { get; set; }
        public int Direccion { get; set; }
        public int Edad { get; set; }
        public int Evaluacion { get; set; }
        public int Legajo { get; set; }
        public int Property { get; set; }
        public int MateriaCC_Profesor { get; set; }
        public int Nombre { get; set; }
        public List<Evaluacion> Evaluacion1 { get; set; }
        public List<MateriaCC_Profesor> MateriaCC_Profesor1 { get; set; }

    }
}