using System.Collections.Generic;

namespace Interfaces
{
    public interface IIdioma : IEntity
    {
        string Nombre { get; set; }        

        string BuscarTraduccion(string texto);
        

        //bool Default { get; set; }

    }
}
