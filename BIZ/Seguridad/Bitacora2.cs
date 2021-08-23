using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ.Seguridad
{
    public class Bitacora2
    {
        public int IdBitacora { get; set; }

        public int IdUsuario { get; set; }

        public int IdTipoBitacora { get; set; }

        public DateTime FechaHora { get; set; }

        public string Mensaje { get; set; }

        public bool Habilitado { get; set; }

      
        public Int64 DigitoHorizontal { get; set; }

        public TipoBitacora TipoBitacora { get; set; }

        public Usuario Usuario { get; set; }
    }
}
