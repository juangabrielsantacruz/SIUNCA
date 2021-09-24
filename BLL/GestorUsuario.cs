using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BIZ;
using Framework.D_2015.Cache;
using BIZ.Seguridad;

namespace BLL
{
    public class GestorUsuario
    {
        UsuarioDAO unUsuarioDAO = new UsuarioDAO();


        public Usuario traerUsuario(Usuario usuario)
        {
            if (SesionSingleton.IsLogged())
                { 
                    throw new Exception("Ya hay una sesión iniciada");
                }

            var unUsuario = unUsuarioDAO.traerUsuario(usuario);


            //if (!user) throw new LoginException(LoginResult.CredencialesInvalidas);
            if (unUsuario == null)
                {
                    throw new Exception("crednediales invalidas// faltan crear excepciones");
            }
            else
            {
                SesionSingleton.Login(CargarPermisos(unUsuario));
                return SesionSingleton.Instancia.usuario;
            }
                
                 
        
            //Carga las variables cache por medio de linq, para poder usarlas a nivel global en el sistema,
            //los datos se mantienen siempre y cuando el sistema no se cierre
            //CacheUsuario.iduser = listaUsuario.Select(x => x.iduser).FirstOrDefault();
            //CacheUsuario.password = listaUsuario.Select(x => x.password).FirstOrDefault();
            //CacheUsuario.username = listaUsuario.Select(x => x.username).FirstOrDefault();
            //CacheUsuario.email = listaUsuario.Select(x => x.email).FirstOrDefault();
            //CacheUsuario.rol = listaUsuario.Select(x => x.rol).FirstOrDefault();
            //CacheUsuario.iduser = unUsuario.iduser;

            //si devuelve null significa que se ingreso un dato incorrecto en el form login
            //var user = unUsuario.Where(x => x.email == usuario.email && x.password == usuario.password && x.rol == usuario.rol).FirstOrDefault();


            // Logueo (traigo perfil) del Usuario            

            
        }

        public void eliminarUsuario(int idUsuario)
        {
            unUsuarioDAO.eliminar(idUsuario);
        }

        public void guardarUsuario(Usuario usuario)
        {
            var unUsuarioDAO = new UsuarioDAO();
            unUsuarioDAO.insertarUsuario(usuario);
        }

        public List<Usuario> TraerTodo()
        {
            return unUsuarioDAO.TraerTodo();
        }

        public Usuario CargarPermisos(Usuario unUsuario)
        {
            // Logueo (traigo perfil) del Usuario
            return unUsuarioDAO.TraerPermisos(unUsuario);
        }

        public void GuardarPermisos(Usuario unUsuario)
        {
            unUsuarioDAO.GuardarPermisos(unUsuario);
        }


    }
}
