using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.D_2015.Multiidioma;
using Framework.D_2015.Persistencia;
using Interfaces;

namespace BIZ.Seguridad
{
    public class SesionSingleton : IObservado
    {
        //deberia hacer esta clase en el FRAMEWORK
        private static SesionSingleton _instancia;

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



        /* MULTIIDIOMA */

        public Idioma idioma { get; set; }
        public IList<IObservador> ObservadoresRegistrados { get; set; }

        private SesionSingleton()
        {
            ObservadoresRegistrados = new List<IObservador>();
        }
        public void CambiarIdioma(Idioma i)
        {
            idioma = i;
            ActualizarObservadores(i);
        }

        public void ActualizarObservadores(IIdioma idioma)
        {
            foreach (var item in ObservadoresRegistrados)
            {
                item.Actualizar(idioma);
            }
        }

        public void DesregistrarObservador(IObservador observador)
        {
            ObservadoresRegistrados.Remove(observador);
        }

        public void RegistrarObservador(IObservador observador)
        {
            ObservadoresRegistrados.Add(observador);
        }

   
    }
}
