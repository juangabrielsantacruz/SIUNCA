﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ.GestionPlanes
{
    public class DetallesPlan
    {
        [System.ComponentModel.Browsable(true)]
        public int IdDetallePlan { get; set; }
        [System.ComponentModel.Browsable(false)]
        public int IdPlanDeEstudio { get; set; }
        public Materia Materia { get; set; }
        public int NumeroMateria { get; set; }
        public int Año { get; set; }
        public int Cuatrimestre { get; set; }
        public int CargaHorariaTotal { get; set; }
        //public bool Obligatoriedad { get; set; }
        public List<DetallesPlan> DetallesDetallePlanCorrelativas { get; set; }
    }
}
