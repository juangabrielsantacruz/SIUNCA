using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using Microsoft.VisualBasic;



namespace BIZ.Seguridad
{
    public class Patente2 : Permiso
    {
        public override bool Validar(int id)
        {
            return this.Id.Equals(id);
        }

        public override bool Equals(object obj)
        {
            if (!(obj == null) && obj is Patente2)
                return ((Patente2)obj).Id.Equals(this.Id);
            else
                return false;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1})", this.Descripcion, this.Id);
        }

        public override List<Permiso> ListaCompleta
        {
            get
            {
                List<Permiso> _lista = new List<Permiso>();
                _lista.Add(this);
                return _lista;
            }
        }
    }

}
