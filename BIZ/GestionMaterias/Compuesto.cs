using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ.GestionMaterias
{
    public abstract class Compuesto
    {
        public string Nombre { get; set; }
        public int Id { get; set; }

        public abstract IList<Compuesto> Hijos { get; }
        public abstract void AgregarHijo(Compuesto c);
        public abstract void VaciarHijos();
        public DuracionMateria Duracion { get; set; }

        public override string ToString()
        {
            return Nombre;
        }

    }
}
