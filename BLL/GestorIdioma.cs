using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIZ;
using DAL;
using Framework.D_2015.Observer;

namespace BLL
{
    public class GestorIdioma : IObservado
    {
        public List<IObservador> ObservadoresRegistrados => throw new NotImplementedException();

        public void ActualizarObservadores()
        {
            throw new NotImplementedException();
        }

        public void DesregistrarObservador(IObservador pObservador)
        {
            throw new NotImplementedException();
        }

        public void RegistrarObservador(IObservador pObservador)
        {
            throw new NotImplementedException();
        }
    }
}
