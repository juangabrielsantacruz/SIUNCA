using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIZ
{
    public class Carrera : Bitacora
    {
        public int IdCarrera { get; set; }
        public String  Nombre { get; set; }
        public List<Curso> Curso { get; set; }
        public List<Alumno> Alumnos { get; set; }
        public List<PlanDeEstudio> PlanDeEstudio { get; set; }
    }
}