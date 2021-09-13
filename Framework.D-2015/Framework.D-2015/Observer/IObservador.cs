using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Framework.D_2015.Observer
{
    public interface IObservador
    {
        void Actualizar(Control pObservador);
    }
}
