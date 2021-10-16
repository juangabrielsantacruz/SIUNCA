using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIZ.Seguridad;

namespace BIZ
{
    public class Usuario
    {
        public int iduser { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string rol { get; set; }


        /// <summary>
        /// ///////
        /// </summary>

        //private string _contraseña;
        private int _idUsuario;
        //private string _nombre;

        private Familia2 _perfil;


        public Familia2 Perfil
        {
            get
            {
                return this._perfil;
            }
            set
            {
                this._perfil = value;
            }
        }

        public override bool Equals(object obj)
        {
            if (!(obj == null) && obj is Usuario)
                return ((Usuario)obj).iduser.Equals(this.iduser);
            else
                return false;
        }

        public void QuitarFamilia(Familia2 unaFamilia)
        {
            Perfil.Quitar(unaFamilia);
        }
        public void AgregarFamilia(Familia2 unaFamilia)
        {
            Perfil.Agregar(unaFamilia);
        }

        public void QuitarPatente(Patente2 unaPatente)
        {
            Perfil.Lista.Remove(unaPatente);
        }

        public void AgregarPatente(Patente2 unaPatente)
        {
            Perfil.Lista.Add(unaPatente);
        }

        ////////////////////
        ///nuevo
        public Usuario()
        {
            _permisos = new List<Componente>();
        }
        List<Componente> _permisos;

        public List<Componente> Permisos
        {
            get
            {
                return _permisos;
            }
        }

        public override string ToString()
        {
            return username;
        }

        //cierre nuevo
        /////////////////

    }
}
