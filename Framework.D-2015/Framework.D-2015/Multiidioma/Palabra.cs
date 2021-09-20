using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.D_2015.Multiidioma
{
    public class Palabra : Entity, IPalabra
    {
        public string Texto { get; set; }
    }
}
