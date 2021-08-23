using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIZ
{
    public class DetallesPlanDeEstudio : Bitacora
    {
        public int IdPlanDeEstudio { get; set; }
        public int NumeroMateria { get; set; }
        public string NombreMateria { get; set; }
        public int Año { get; set; }
        public string Obligatoriedad { get; set; }
        public int CargaHoraria { get; set; }
        public int IdMateriaCC { get; set; }
        
        public int IdPlanDetalles { get; set; }
        
        
        

    }
}