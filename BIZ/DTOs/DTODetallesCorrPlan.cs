using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ.DTOs
{
    public class DTODetallesCorrPlan : Bitacora
    {
        public int IdDetallesDetMatPlanCorrPlan { get; set; }
        public int IdPlanDetalles { get; set; }
        public int IdPlanDetalles2 { get; set; }
        public int NumeroMateria { get; set; }
        public int NumeroMateria2 { get; set; }
        public string Nombre { get; set; }
        public string NombreMateria2 { get; set; }
        public int Año { get; set; }
        public string Obligatoriedad { get; set; }
        public int CargaHoraria { get; set; }
        public int IdMateriaCC { get; set; }
        public int IdPlanDeEstudio { get; set; }
        public string NombrePlan { get; set; }


    }
}
