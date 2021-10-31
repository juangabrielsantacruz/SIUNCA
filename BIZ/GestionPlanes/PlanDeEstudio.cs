using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ.GestionPlanes
{
    public class PlanDeEstudio
    {
        public int IdPlanDeEstudio { get; set; }
        public int IdCarrera { get; set; }      
        public string Nombre { get; set; }
        public List<DetallesPlan> Detalles { get; set; }
    }
}
