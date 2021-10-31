using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ.GestionMaterias
{
    public class Materia : Compuesto
    {
        public override IList<Compuesto> Hijos
        {
            get
            {
                return new List<Compuesto>();
            }
        }

        public override void AgregarHijo(Compuesto c)
        {

        }

        public override void VaciarHijos()
        {

        }
    }
}
