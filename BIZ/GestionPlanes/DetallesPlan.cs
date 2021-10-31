using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ.GestionPlanes
{
    public class DetallesPlan
    {
        //IdDet, IdPlan, IdMateria, Año, Cuatrimestre, CargaHorariatotal, ListOf DetallesDetallePlan
        public int IdDetallePlan { get; set; }
        public int IdPlanDeEstudio { get; set; }
        public Materia Materia { get; set; }
        public int Año { get; set; }
        public int Cuatrimestre { get; set; }
        public int CargaHorariaTotal { get; set; }
        public bool Obligatoriedad { get; set; }
        public List<DetallesDetallePlan> DetallesDetallePlan { get; set; }
    }
}
