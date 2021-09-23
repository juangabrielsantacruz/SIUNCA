using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.D_2015.Multiidioma
{
    public class Traduccion :  ITraduccion
    {
        public int IdPalabra_Traduccion { get; set; }
        public string PalabraTraducida { get; set; }

        public string Palabra_Texto { get; set; }
    }
}
