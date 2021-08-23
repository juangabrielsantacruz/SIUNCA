using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ.Seguridad
{
    
        public abstract class Permiso
        {
            private int _id;
            public int Id
            {
                get
                {
                    return _id;
                }
                set
                {
                    _id = value;
                }
            }

            private string _descripcion;
            public string Descripcion
            {
                get
                {
                    return _descripcion;
                }
                set
                {
                    _descripcion = value;
                }
            }

            public abstract bool Validar(int id);

            public abstract List<Permiso> ListaCompleta { get; }
        }

    
}
