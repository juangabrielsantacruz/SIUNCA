using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ITraduccion : IEntity
    {
        string PalabraTraducida { get; set; }
        IPalabra Palabra { get; set; }
    }
}
