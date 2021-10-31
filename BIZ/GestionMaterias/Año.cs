using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ.GestionMaterias
{
    public class Año : Compuesto
    {
        private IList<Compuesto> _hijos;
        public Año()
        {
            _hijos = new List<Compuesto>();
        }

        public override IList<Compuesto> Hijos
        {
            get
            {
                return _hijos.ToArray();
            }

        }

        public override void VaciarHijos()
        {
            _hijos = new List<Compuesto>();
        }
        public override void AgregarHijo(Compuesto c)
        {
            _hijos.Add(c);
        }
    }
}
