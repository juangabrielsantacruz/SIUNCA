using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIZ
{
    public class PlanDeEstudio : Bitacora
    {
        public int IdCarrera { get; set; }
        public int IdPlanDeEstudio { get; set; }
        public string Nombre { get; set; }
        public string NombreCarrera { get; set; }

    }
}