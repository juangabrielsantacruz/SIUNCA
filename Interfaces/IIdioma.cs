using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IIdioma : IEntity
    {
        string Nombre { get; set; }
        IList<ITraduccion> Traducciones { get; set; }
        void AgregarTraduccion(ITraduccion traduccion);
        string BuscarTraduccion(string texto);
    }
}
