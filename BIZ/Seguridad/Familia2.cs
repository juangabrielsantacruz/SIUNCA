using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ.Seguridad
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Security;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.VisualBasic;

    public class Familia2 : Permiso
    {
        private List<Permiso> _lista = new List<Permiso>();

        public void Agregar(Permiso permiso)
        {
            if (!(permiso == null))
            {
                if (!this._lista.Contains(permiso))
                    this._lista.Add(permiso);
                else
                {
                }
            }
            else
            {
            }
        }

        public object Quitar(Permiso permiso)
        {
            return this._lista.Remove(permiso);
        }

        public List<Permiso> Hijos()
        {
            return this._lista;
        }

        public List<Permiso> Lista
        {
            get
            {
                return this._lista;
            }
        }


        public override bool Validar(int id)
        {
            //recorro cada patente en la lista de patentes y la comparo con el int que mando en validar si son iguales true (pantente.idequals(int)
            bool resultado = default(bool);
            foreach (Permiso _permiso in this.Lista)
                resultado = (resultado | _permiso.Validar(id));
            return resultado;
        }

        public override System.Collections.Generic.List<Permiso> ListaCompleta
        {
            get
            {
                List<Permiso> _lista = new List<Permiso>();

                foreach (Permiso _permiso in this.Lista)
                    _lista.AddRange(_permiso.ListaCompleta);

                return _lista;
            }
        }
    }


}
