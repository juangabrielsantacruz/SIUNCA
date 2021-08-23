using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIZ
{
    public class DetallesCorrelativa : Bitacora
    {
        public int IdDetallesCorrelativa { get; set; }
        public int IdMateria { get; set; }
        public int IdMateriaCC { get; set; }
        public string NombreMateria { get; set; }
        public string NombreMateriaCC { get; set; }

    }
}