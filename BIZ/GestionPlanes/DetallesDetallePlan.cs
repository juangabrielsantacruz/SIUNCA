using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ.GestionPlanes
{
    public class DetallesDetallePlan
    {
        [System.ComponentModel.Browsable(false)]
        public int IdDetallesDetallePlan { get; set; }
        public int IdDetallesPlan { get; set; }
        //public Materia Materia { get; set; }
    }
}
