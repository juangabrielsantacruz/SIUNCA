using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.D_2015.Persistencia;

namespace BIZ.Seguridad
{
    public class SesionSingleton
    {
        private static SesionSingleton _instancia;
        //private static Object _lock = new object();
        public static SesionSingleton Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new SesionSingleton();

                return _instancia;
            }
        }

        public Usuario usuario { get; set; }

     
        //private int myVar;

        //public int MyProperty
        //{
        //    get { return myVar; }
        //    set { myVar = value; }
        //}

        public void Login(Usuario usuario)
        {
            this.usuario = usuario;
        }
        public bool IsLogged()
        {
            return usuario != null;
        }
        public void Logout()
        {
            usuario = null;
        }
    }
}
