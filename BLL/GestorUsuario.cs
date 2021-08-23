using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BIZ;
using Framework.D_2015.Cache;

namespace BLL
{
    public class GestorUsuario
    {
        UsuarioDAO unUsuarioDAO = new UsuarioDAO();

        public Usuario traerUsuario(Usuario usuario)
        {
            var listaUsuario = new List<Usuario>();
            listaUsuario = unUsuarioDAO.trarTodo(usuario);

            //Carga las variables cache por medio de linq, para poder usarlas a nivel global en el sistema,
            //los datos se mantienen siempre y cuando el sistema no se cierre
            CacheUsuario.iduser = listaUsuario.Select(x => x.iduser).FirstOrDefault();
            CacheUsuario.password = listaUsuario.Select(x => x.password).FirstOrDefault();
            CacheUsuario.username = listaUsuario.Select(x => x.username).FirstOrDefault();
            CacheUsuario.email = listaUsuario.Select(x => x.email).FirstOrDefault();
            CacheUsuario.rol = listaUsuario.Select(x => x.rol).FirstOrDefault();

            //si devuelve null significa que se ingreso un dato incorrecto en el form login
            var user = listaUsuario.Where(x => x.email == usuario.email && x.password == usuario.password && x.rol == usuario.rol).FirstOrDefault();
            
            return user;
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

        public Usuario Login(Usuario unUsuario)
        {
            return unUsuarioDAO.Login(unUsuario);
        }

        public void GuardarPermisos(Usuario unUsuario)
        {
            unUsuarioDAO.GuardarPermisos(unUsuario);
        }


    }
}
