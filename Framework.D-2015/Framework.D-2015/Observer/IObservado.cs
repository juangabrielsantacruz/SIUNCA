using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.D_2015.Observer
{
    public interface IObservado
    {
        List<IObservador> ObservadoresRegistrados { get; }

        void RegistrarObservador(IObservador pObservador);
        void DesregistrarObservador(IObservador pObservador);
        void ActualizarObservadores();
    }
}
