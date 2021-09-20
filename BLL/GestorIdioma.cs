using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIZ;
using DAL;
using Interfaces;

namespace BLL
{
    public class GestorIdioma : IObservado
    {
        public IList<IObservador> ObservadoresRegistrados { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ActualizarObservadores(IIdioma idioma)
        {
            throw new NotImplementedException();
        }

        public void DesregistrarObservador(IObservador observador)
        {
            throw new NotImplementedException();
        }

        public void RegistrarObservador(IObservador observador)
        {
            throw new NotImplementedException();
        }
    }
}
