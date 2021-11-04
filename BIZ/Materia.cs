using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIZ
{
    public class Materia : Bitacora
    {
        public int IdMateria { get; set; }
        public string Nombre { get; set; }

        public override string ToString()
        {

            return Nombre;
        }
    }
}