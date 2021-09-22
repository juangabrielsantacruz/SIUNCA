using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.D_2015.Multiidioma
{
    public class Idioma : Entity, IIdioma
    {
        public string Nombre { get; set; }
        public IList<ITraduccion> Traducciones { get; set; }
        public bool Default { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Idioma()
        {
            Traducciones = new List<ITraduccion>();
        }
        public void AgregarTraduccion(ITraduccion traduccion)
        {
            Traducciones.Add(traduccion);
        }

        public string BuscarTraduccion(string texto)
        {
            return Traducciones.FirstOrDefault(x => x.Palabra.Texto == texto).PalabraTraducida;
        }
    }
}
