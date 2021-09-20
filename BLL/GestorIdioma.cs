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
        //public IList<IObservador> ObservadoresRegistrados { get; set; }

        private List<IObservador> mListaRegistrados = new List<IObservador>();

        /// <summary>
        /// Lista de los observadores registrados para esta instancia
        /// </summary>
        /// <returns></returns>
        public IList<IObservador> ObservadoresRegistrados
        {
            get
            {
                return mListaRegistrados;
            }
            set { }
        }

        /// <summary>
        /// Registra un nuevo observador a la lista
        /// </summary>
        /// <param name="pObservador">Observador que se quiere registrar</param>
        public void RegistrarObservador(IObservador pObservador)
        {
            if (mListaRegistrados.Count > 0)
            {
                foreach (IObservador mObservador in mListaRegistrados)
                {
                    if ((mObservador.ToString() ?? "") == (pObservador.ToString() ?? ""))
                    {
                        mListaRegistrados.Remove(mObservador);
                        break;
                    }
                }
            }

            mListaRegistrados.Add(pObservador);
        }


        /// <summary>
        /// Quita a un observador de la lista
        /// </summary>
        /// <param name="pObservador">Observador que quiere quitarse de la lista</param>
        public void DesregistrarObservador(IObservador pObservador)
        {
            foreach (IObservador mObservador in mListaRegistrados)
            {
                if ((mObservador.ToString() ?? "") == (pObservador.ToString() ?? ""))
                {
                    mListaRegistrados.Remove(mObservador);
                    break;
                }
            }
        }


        /// <summary>
        /// Ejecuta el metodo Actualizar() de todos los observadores registrados en esta instancia
        /// </summary>
        public void ActualizarObservadores(IIdioma idioma)
        {
            foreach (IObservador mObservador in mListaRegistrados)
                mObservador.Actualizar((IIdioma)mObservador);
        }

    }
}
